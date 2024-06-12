
# Blog Application

This is a simple blog application built with ASP.NET Core Web API and Entity Framework Core. It provides a RESTful API for creating, reading, updating, and deleting blog posts.

## Prerequisites

- .NET Core SDK (version 5.0 or later)
- Docker

## Getting Started

1. Clone the repository:

```
git clone https://github.com/your-username/BlogApp.git
```

2. Navigate to the project directory:

```
cd BlogApp
```

3. Build the project:

```
dotnet build
```

4. Run the application:

```
dotnet run
```

The application will start running at `http://localhost:5000` and `https://localhost:5001`.

## Docker Setup

To run the application using Docker, follow these steps:

1. Build the Docker image:

```
docker build -t blogapp .
```

2. Run the Docker container:

```
docker run -p 8080:80 blogapp
```

This will start the application and map the container's port 80 to your local port 8080.

## API Endpoints

The following RESTful API endpoints are available:

- `GET /api/Posts`: Get a list of all blog posts
- `GET /api/Posts/{id}`: Get a specific blog post by ID
- `POST /api/Posts`: Create a new blog post
  - Request body:
    ```json
    {
      "title": "Post Title",
      "content": "Post content goes here..."
    }
    ```
- `PUT /api/Posts/{id}`: Update an existing blog post
  - Request body:
    ```json
    {
      "id": 1,
      "title": "Updated Post Title",
      "content": "Updated post content..."
    }
    ```
- `DELETE /api/Posts/{id}`: Delete a blog post

## Database

This application uses an in-memory database provided by Entity Framework Core. The data will be stored in memory and reset when the application is restarted.

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvement, please open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
```

