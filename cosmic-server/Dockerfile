FROM node:alpine
WORKDIR /cosmic

# install
COPY ./src/firebase/functions/package*.json ./src/firebase/functions/
RUN mkdir -p ./src/firebase/functions/node_modules
RUN npm install --prefix ./src/firebase/functions

ARG FIREBASE_TOKEN
ARG FIREBASE_TARGET="test"

COPY . .
RUN npm run --prefix ./src/firebase/functions set-project:${FIREBASE_TARGET} -- --token "${FIREBASE_TOKEN}"

# execute
ENTRYPOINT [ "npm", "run", "--prefix", "./src/firebase/functions", "deploy", "--" ]