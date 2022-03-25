FROM node:14.15.0-alpine3.12 as builder

ENV REACT_APP_HOST_ENV PRODUCTION

WORKDIR /app
COPY package.json package-lock.json ./

RUN npm install --production

COPY . ./

EXPOSE 8080

CMD ["npm", "start"]