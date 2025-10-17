# Step 1: Use Node to build the Angular app
FROM node:20 AS build
WORKDIR /app
COPY package*.json ./
RUN npm ci
COPY . .
RUN npm run build --if-present

# Step 2: Use Nginx to serve the built app
FROM nginx:alpine
COPY --from=build /app/dist/taskflow/browser /usr/share/nginx/html
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]
