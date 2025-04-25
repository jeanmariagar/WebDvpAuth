# WebDvpAuth API (.NET 8 + Docker)

Este proyecto es una API RESTful construida con .NET 8 para el manejo de autenticación de usuarios (registro, login, y lectura), y contiene varias capas separadas: `WebDvpDatabase`, `WebDvpLogic` y `WebDvpApi`. 

---

## 🚀 Tecnologías Utilizadas

- ASP.NET Core 8
- Entity Framework Core
- Swagger para documentación
- SQL Server (para conexión a base de datos)

---

## ⚙️ Estructura del Proyecto

![image](https://github.com/user-attachments/assets/11eee772-323e-4e4c-9eb8-ca81cd849198)



## 🔗 Configuración de la conexión a la base de datos

En el archivo `appsettings.json`, se usa la siguiente cadena de conexión:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=CalculadoraDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

⚠️ Notas importantes

Si Swagger no aparece, asegúrate de no estar en modo "Producción" o de haberlo habilitado manualmente para producción en tu código (Program.cs).

La advertencia sobre "DataProtection Keys" es normal. Para entornos productivos, se recomienda configurar almacenamiento persistente o cifrado.

✅ Estado

✔️ API funcional con tokens JWT✔️ Swagger funcionando localmente en modo desarrollo

## ⚙️ Manual

![image](https://github.com/user-attachments/assets/58b3f400-98c3-4a12-a6dc-f4653ef84d2c)

datos
![image](https://github.com/user-attachments/assets/126a4f4c-367f-4c95-b513-0787c38527fd)


response

![image](https://github.com/user-attachments/assets/c567d178-b2e7-488a-8716-5e75f463ee2d)

registro en tabla usuario

![image](https://github.com/user-attachments/assets/8f6325ba-8ebf-4719-9cde-8f214eb29f54)


Login
![image](https://github.com/user-attachments/assets/438b12b2-c03f-42a0-9ead-246cf1249851)

datos
![image](https://github.com/user-attachments/assets/4d324e97-6881-4cb4-b947-addc66090fcd)

response

![image](https://github.com/user-attachments/assets/f879e195-3407-4395-a5a6-d9983fb38ebc)


Perfil
![image](https://github.com/user-attachments/assets/e9ef59f3-2a72-4802-9ee3-1c6d0f8bd380)

Candado Autorizar. Uso clave de token que obtuve de Login
![image](https://github.com/user-attachments/assets/dc020f51-0beb-43d2-a54d-0d7ba4436b62)

![image](https://github.com/user-attachments/assets/b83de219-3d05-4935-8b44-7173eb77ff09)

exceeute

![image](https://github.com/user-attachments/assets/48faea50-c8a0-4e44-9b22-4c9d1c70cb71)


Response

![image](https://github.com/user-attachments/assets/db32bd11-50d2-4398-9749-fa708296a515)


📌 Autora

Jeannete Monroy– Lima, Perú 🇵🇪
