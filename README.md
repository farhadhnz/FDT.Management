# FDT.Management (Digital Twin Management Microservice)

The Digital Twin Management Microservice is a component of a larger system that provides capabilities for managing digital twins. It allows users to create, retrieve, update, and delete digital twin projects and entities, as well as perform various operations related to digital twin management.

## Features

- Create new digital twin projects with customizable properties.
- Create, update, and delete digital twin entities within a project.
- Retrieve information about digital twin projects and entities.
- Perform operations related to digital twin management.

## API Documentation

The API documentation provides detailed information about the endpoints, request/response formats, and authentication mechanisms. You can access the API documentation by visiting `http://localhost:3000/api-docs` when the microservice is running.

## Database

The Digital Twin Management Microservice uses a database to store digital twin projects and entities. The default database configuration is PostgreSQL, but you can use a different database by updating the configuration values in the `.env` file.

The microservice uses Entity Framework Core to handle database operations. When the microservice is started for the first time, it automatically creates the necessary database schema based on the entity models.

## Contributing

Contributions to the Digital Twin Management Microservice are welcome! If you find a bug, have an enhancement suggestion, or would like to contribute code, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature/bugfix: `git checkout -b feature/your-feature`.
3. Make your changes and commit them: `git commit -am 'Add some feature'`.
4. Push the changes to your forked repository: `git push origin feature/your-feature`.
5. Open a pull request against the `main` branch of the original repository.

Please ensure that your code adheres to the existing code style and includes appropriate tests.

## License

This project is licensed under the [MIT License](LICENSE).
