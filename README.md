# Vehicle Store

A complete **C# vehicle inventory and shopping application** built around a reusable class library, with both **Windows Forms** and **console** clients plus automated xUnit tests.

<p>
  <img src="https://img.shields.io/badge/C%23-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt=".NET 10" />
  <img src="https://img.shields.io/badge/Windows%20Forms-Desktop-0078D4?style=flat-square&logo=windows11&logoColor=white" alt="Windows Forms" />
  <img src="https://img.shields.io/badge/Tests-xUnit-238636?style=flat-square" alt="xUnit" />
  <img src="https://img.shields.io/badge/Status-Complete-238636?style=flat-square" alt="Project status: Complete" />
</p>

## Overview

Vehicle Store is a desktop practice project centered on object-oriented design and reusable application logic. The solution models several vehicle types, maintains a store inventory, supports a shopping cart and checkout workflow, persists inventory to a local file, and exposes the same core functionality through both graphical and console interfaces.

The shared class library contains the vehicle models and store services, allowing the presentation applications to focus on user interaction rather than duplicating inventory logic.

## Features

- Add vehicles to a store inventory
- Support for general vehicles, cars, motorcycles, and pickups
- Vehicle-specific properties for each specialized model
- Duplicate vehicle detection
- Automatically assigned inventory IDs
- Add inventory items to a shopping cart
- Remove items from the shopping cart
- Calculate the checkout total and clear the completed cart
- Save inventory to a local text file
- Reload persisted inventory from disk
- Input validation in the Windows Forms client
- Windows Forms graphical interface
- Separate console-based interface using the same class library
- Automated xUnit tests for store logic
- Layered model, business-logic, and data-access structure

## Vehicle Model

The project uses `VehicleModel` as the base representation for common vehicle information:

- Make
- Model
- Year
- Price
- Number of wheels
- Color
- Mileage

Specialized models extend the base vehicle with their own properties:

| Type | Additional Properties |
| --- | --- |
| Car | Convertible status, trunk size |
| Motorcycle | Sidecar status, seat height |
| Pickup | Bed-cover status, bed size |

The models override string formatting for readable inventory displays and implement equality comparisons so duplicate entries can be rejected.

## Store Workflow

The application supports a complete small-store workflow:

1. Select the vehicle type to create.
2. Enter the common vehicle information.
3. Enter the type-specific details when applicable.
4. Add the vehicle to inventory.
5. Select inventory items and add them to the shopping cart.
6. Remove cart items if needed.
7. Checkout to calculate the total purchase price.
8. Save the inventory to disk and reload it in a later session.

The Windows Forms client updates the fields shown for cars, motorcycles, pickups, and general vehicles so each type collects the appropriate information.

## Architecture

The solution separates the reusable application logic from its user interfaces.

```text
VehicleStore/
├── VehicleClassLibrary/
│   ├── Models/
│   │   ├── VehicleModel.cs
│   │   ├── CarModel.cs
│   │   ├── MotorcycleModel.cs
│   │   └── PickupModel.cs
│   ├── Services/
│   │   ├── BusinessLogicLayer/
│   │   │   └── StoreLogic.cs
│   │   └── DataAccessLayer/
│   │       └── StoreDAO.cs
│   └── VehicleClassLibrary.csproj
├── VehicleStoreGUIApp/
│   ├── FrmVehicleStore.cs
│   └── VehicleStoreGUIApp.csproj
├── VehicleStoreConsoleApp/
│   ├── Program.cs
│   └── VehicleStoreConsoleApp.csproj
├── VehicleClassLibrary.Tests/
│   ├── StoreLogicTests.cs
│   └── VehicleClassLibrary.Tests.csproj
└── VehicleClassLibrary.slnx
```

### Models

The model layer defines the common vehicle representation and specialized derived vehicle types.

### Business Logic

`StoreLogic` provides the operations used by both presentation clients, including inventory access, shopping-cart operations, persistence requests, and checkout.

### Data Access

`StoreDAO` manages the in-memory inventory and shopping cart and handles serialization of the different vehicle types to `Data/Inventory.txt`.

When inventory is loaded, the stored vehicle type is used to reconstruct the corresponding `VehicleModel`, `CarModel`, `MotorcycleModel`, or `PickupModel` object.

## Two User Interfaces

### Windows Forms

`VehicleStoreGUIApp` provides the primary graphical interface. It includes field validation, dynamically changing vehicle-specific controls, inventory and shopping-cart lists, save/load controls, and checkout total display.

### Console

`VehicleStoreConsoleApp` provides an alternate text-based interface backed by the same shared vehicle and store logic. Including both clients demonstrates that the core application behavior is reusable independently of a particular presentation layer.

## Inventory Persistence

The store can save its inventory to:

```text
Data/Inventory.txt
```

Each saved record includes the vehicle type followed by the properties needed to reconstruct that object. Loading the inventory recreates the appropriate specialized model and repopulates the store.

## Testing

The solution includes a dedicated xUnit test project with Microsoft.NET.Test.Sdk and Coverlet support.

Run the tests with:

```bash
dotnet test VehicleClassLibrary.Tests/VehicleClassLibrary.Tests.csproj
```

## Running the Project

### Requirements

- Windows 10 or Windows 11 for the Windows Forms client
- Visual Studio with .NET desktop development support, or the .NET 10 SDK

Clone the repository:

```bash
git clone https://github.com/IPFizzy/VehicleStore.git
cd VehicleStore
```

Open `VehicleClassLibrary.slnx` in Visual Studio.

### Run the graphical client

```bash
dotnet run --project VehicleStoreGUIApp/VehicleStoreGUIApp.csproj
```

### Run the console client

```bash
dotnet run --project VehicleStoreConsoleApp/VehicleStoreConsoleApp.csproj
```

### Build the full solution

```bash
dotnet build VehicleClassLibrary.slnx
```

## Practice Project Context

This repository began as an object-oriented programming and class-library exercise and is preserved as a completed practice project. The finished solution demonstrates inheritance, polymorphic collections, equality overrides, validation, reusable business logic, text-file persistence, multiple presentation layers, shopping-cart state, and automated testing.

## Author

**Keon Bushman**  
Software Development Student & IT Professional  
[GitHub Profile](https://github.com/IPFizzy)
