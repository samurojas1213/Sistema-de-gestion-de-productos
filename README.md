# Sistema de Gestión de Productos

**Tarea programada** – Programación II  
Universidad Internacional San Isidro Labrador (UISIL)  
Profesor: Ing. Joshua Granados Loría

## Integrantes
- Samuel Rojas Víquez

## Descripción del sistema
Aplicación de escritorio para administrar los productos de una pequeña tienda. Permite gestionar categorías y productos mediante operaciones de registro, consulta, modificación y eliminación. Cada producto pertenece a una categoría y los datos se almacenan en una base de datos SQL Server.

## Tecnologías utilizadas
- Lenguaje: C#
- Interfaz: Windows Forms
- Entorno: Visual Studio
- Base de datos: Microsoft SQL Server
- Administración de la base de datos: SQL Server Management Studio (SSMS)
- Paquete NuGet: Microsoft.Data.SqlClient

## Requisitos para ejecutar el programa
- Windows
- Visual Studio con la carga de trabajo de desarrollo de escritorio de .NET
- SQL Server (por ejemplo, Express) y SQL Server Management Studio

## Instrucciones para crear la base de datos
1. Abrir SQL Server Management Studio y conectarse al servidor.
2. Abrir una nueva consulta.
3. Abrir el archivo `ScriptBaseDatos.sql` de este repositorio y copiar su contenido en la consulta.
4. Ejecutarlo una sola vez (F5). El script crea la base `GestionProductosDB`, las tablas `Categorias` y `Productos`, la llave foránea y datos de prueba.

## Información para la conexión a SQL Server
El sistema usa una instancia local de SQL Server Express con autenticación de Windows. La cadena de conexión está en `Datos/Conexion.cs`:

```
Server=.\SQLEXPRESS;Database=GestionProductosDB;Trusted_Connection=True;TrustServerCertificate=True;
```

Si en otra computadora el servidor tiene un nombre distinto (por ejemplo `localhost`), se debe modificar el valor de `Server` en ese archivo. El nombre del servidor es el mismo que se escribe al conectarse en SQL Server Management Studio.

## Instrucciones para ejecutar el sistema
1. Clonar o descargar el repositorio.
2. Abrir el archivo `.sln` con Visual Studio.
3. Verificar que la cadena de conexión coincida con el servidor local.
4. Presionar F5 para ejecutar.

## Estructura del proyecto
- `Modelos/`: clases `Categoria` y `Producto`.
- `Datos/`: conexión y operaciones con SQL Server.
- `Logica/`: validaciones y reglas del sistema.
- `Interfaz/`: formularios de Windows Forms.

## Funcionalidades principales
- Registrar, consultar, modificar y eliminar categorías.
- Registrar, consultar, modificar y eliminar productos.
- Asignar una categoría a cada producto (obligatoria).
- Buscar productos por nombre.
- Mostrar los productos en un DataGridView con su valor de inventario (precio × stock), calculado por la aplicación.
- Fecha de registro automática al crear un producto.
- Validaciones con ErrorProvider y mensajes con MessageBox.

## Uso de inteligencia artificial
- **Herramienta utilizada:** Claude (Anthropic).
- **Propósito:** apoyo para el diseño del script SQL, la estructura por capas, ejemplos de código en C#, depuración de errores y orientación para usar Git y GitHub.
- **Partes del proyecto en las que se utilizó:** base de datos, capa de datos, capa de lógica, formularios y documentación.
