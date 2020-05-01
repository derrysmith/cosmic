function exportFirebaseFunctions() {
	const admin = require("firebase-admin");
	const funcs = require("firebase-functions");
	const globs = require("glob");
	
	// initialize firebase admin
	try { admin.initializeApp(); } catch (err) { console.error(err); }

	// create context for dependency injection
	const cntxt = { admin, funcs, environment: process.env.NODE_ENV };

	// get all *.func.js files
	const files = globs.sync("./src/**/*.func.js", { cwd: __dirname, ignore: [ "./node_modules/**" ]});
	files.forEach(file => {
		// extract function name from file path
		const rgex = /^.*src\/(.+?)\/.*\.func\.js$/gm;
		const func = rgex.exec(file)[1];

		exportFirebaseFunction(func, file, cntxt);
	});
}

function exportFirebaseFunction(func, file, context) {
	// only export the function being invoked
	if (!process.env.FUNCTION_NAME || process.env.FUNCTION_NAME === func) {
		const GoogleCloudFunction = require(file);
		const googleCloudFunction = GoogleCloudFunction(context);

		exports[func] = googleCloudFunction;
	}
}

exportFirebaseFunctions();