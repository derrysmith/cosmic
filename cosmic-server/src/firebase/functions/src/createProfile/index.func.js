module.exports = ({ admin, funcs, environment }) => {
	return funcs.firestore.document("profiles/{pid}").onCreate((snapshot, context) => {
		console.log("document snapshot", snapshot);
	});
};