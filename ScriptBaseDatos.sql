USE master;
GO

-- Si la base ya existe, la borra para empezar limpio
IF DB_ID('GestionProductosDB') IS NOT NULL
BEGIN
    ALTER DATABASE GestionProductosDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE GestionProductosDB;
END
GO

-- Crear la base de datos
CREATE DATABASE GestionProductosDB;
GO

USE GestionProductosDB;
GO

-- Tabla 1: Categorias
CREATE TABLE Categorias (
    IdCategoria INT IDENTITY(1,1) NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(200) NULL,
    CONSTRAINT PK_Categorias PRIMARY KEY (IdCategoria)
);
GO

-- Tabla 2: Productos
CREATE TABLE Productos (
    IdProducto INT IDENTITY(1,1) NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Stock INT NOT NULL,
    FechaRegistro DATETIME NOT NULL,
    IdCategoria INT NOT NULL,
    CONSTRAINT PK_Productos PRIMARY KEY (IdProducto),
    CONSTRAINT FK_Productos_Categorias FOREIGN KEY (IdCategoria)
        REFERENCES Categorias (IdCategoria),
    CONSTRAINT CK_Productos_Precio CHECK (Precio > 0),
    CONSTRAINT CK_Productos_Stock CHECK (Stock >= 0)
);
GO

-- Datos de prueba
INSERT INTO Categorias (Nombre, Descripcion) VALUES
('Computación', 'Equipos y componentes de cómputo'),
('Accesorios', 'Periféricos y accesorios'),
('Impresión', 'Impresoras y suministros'),
('Redes', 'Cables y equipos de red');

INSERT INTO Productos (Nombre, Precio, Stock, FechaRegistro, IdCategoria) VALUES
('Teclado', 12500.00, 20, GETDATE(), 2),
('Mouse', 8000.00, 35, GETDATE(), 2),
('Monitor', 95000.00, 10, GETDATE(), 1),
('Impresora', 120000.00, 5, GETDATE(), 3),
('Cable de red', 3500.00, 50, GETDATE(), 4),
('Memoria USB', 6000.00, 40, GETDATE(), 2);
GO