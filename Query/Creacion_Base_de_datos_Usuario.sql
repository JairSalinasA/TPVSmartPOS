-- Crear la base de datos SmartPOS
CREATE DATABASE SmartPOS;
GO

-- Seleccionar la base de datos SmartPOS
USE SmartPOS;
GO

-- Crear la tabla de usuarios
CREATE TABLE Usuarios (
    UsuarioID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Apellido NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    Contrasena NVARCHAR(255) NOT NULL,
    Telefono NVARCHAR(15),
    FechaNacimiento DATE,
    FechaRegistro DATETIME DEFAULT GETDATE(),
    UltimoAcceso DATETIME DEFAULT GETDATE(),
    Activo BIT DEFAULT 1
);
GO

-- Insertar un nuevo usuario
INSERT INTO Usuarios (Nombre, Apellido, Email, Contrasena, Telefono, FechaNacimiento)
VALUES ('Juan', 'Perez', 'juan.perez@example.com', 'hashed_password', '123456789', '1990-01-01');
GO

-- Seleccionar todos los usuarios
SELECT * FROM Usuarios;
GO

-- Seleccionar un usuario específico por UsuarioID
SELECT * FROM Usuarios WHERE UsuarioID = 1;
GO

-- Actualizar la información de un usuario
UPDATE Usuarios
SET Nombre = 'Juan Carlos', Apellido = 'Perez Lopez', Telefono = '987654321'
WHERE UsuarioID = 1;
GO

-- Desactivar un usuario
UPDATE Usuarios
SET Activo = 0
WHERE UsuarioID = 1;
GO

-- Activar un usuario
UPDATE Usuarios
SET Activo = 1
WHERE UsuarioID = 1;
GO

-- Eliminar un usuario específico
DELETE FROM Usuarios
WHERE Usuari oID = 1;
GO
