FROM ghcr.io/pnpm/pnpm:11 AS build

RUN pnpm runtime set node 24 -g

RUN pnpm install -g http-server

WORKDIR /app

COPY ./src ./src
COPY ./public ./public
COPY ./index.html .
COPY ./package.json .
COPY ./vite.config.js .

RUN pnpm install

RUN pnpm build

RUN ls -lah
RUN ls -lah ./dist
RUN ls -lah ./dist/assets

FROM nginx:alpine

COPY --from=build /app/dist /usr/share/nginx/html
COPY nginx.conf /etc/nginx/conf.d/default.conf

EXPOSE 80