# Modular Mono Dot Repo

## Overview

This repository contains a simple .NET Web Application designed with a modular monolith architecture. It is primarily intended for testing and exploring various concepts related to modular monolith architecture. The application serves as a practical foundation for understanding modular design principles, modularity in monoliths, and their implementation in .NET.

## Repository Structure

The repository follows a modular monolith organization. Below is a high-level structure of the project:

```
/Bootstrapper
	Bootstrapper.csproj
/Modules
	/A
		Modules.A.Api.csproj
		Modules.A.UnitTests.csproj
	/B
    	Modules.B.Api.csproj
		Modules.B.UnitTests.csproj
	.
	.
	.
	/J
```

Each module contains API layer with one GET endpoint, which returns `Hello from Module {module name}!` message.  In modules we also have UnitTests .csproj with single test for that GET endpoint.