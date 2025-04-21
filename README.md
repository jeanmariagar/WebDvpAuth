# WebDvpAuth API (.NET 8 + Docker)

Este proyecto es una API RESTful construida con .NET 8 para el manejo de autenticación de usuarios (registro, login, y lectura), y contiene varias capas separadas: `WebDvpDatabase`, `WebDvpLogic` y `WebDvpApi`. El despliegue se realiza mediante Docker.

---

## 🚀 Tecnologías Utilizadas

- ASP.NET Core 8
- Entity Framework Core
- Swagger para documentación
- Docker para despliegue
- SQL Server (para conexión a base de datos)

---

## ⚙️ Estructura del Proyecto

WebDvpAuth/
 ├── WebDvpApi/ # Capa de presentación (API) 
 ├── WebDvpLogic/ # Lógica de negocio 
 ├── WebDvpDatabase/ # Acceso a datos 
 └── Dockerfile # Para contenerizar la API
 

## 🔗 Configuración de la conexión a la base de datos

En el archivo `appsettings.json`, se usa la siguiente cadena de conexión:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=CalculadoraDB;Trusted_Connection=True;TrustServerCertificate=True;"
}




⚠️ Notas importantes

Si Swagger no aparece, asegúrate de no estar en modo "Producción" o de haberlo habilitado manualmente para producción en tu código (Program.cs).

La advertencia sobre "DataProtection Keys" es normal. Para entornos productivos, se recomienda configurar almacenamiento persistente o cifrado.

✅ Estado

✔️ API funcional con tokens JWT✔️ Corre en Docker correctamente✔️ Swagger funcionando localmente en modo desarrollo


📌 Autora

Jeannete Monroy– Lima, Perú 🇵🇪