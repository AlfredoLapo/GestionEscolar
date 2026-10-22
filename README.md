# Sistema de Gestión Escolar - GestionEscolar

Aplicación web desarrollada en ASP.NET Core MVC con Entity Framework Core y SQL Server para la gestión integral de entidades escolares.

---

##  Integrantes y Entidades Asignadas

* **Alfredo Lapo**: Entidad `Estudiante` (CRUD completo)
* **Nathaly Castillo**: Entidad `Maestro` (CRUD completo)
* **Robinson Romero**: Entidad `Aula` (CRUD completo)
* **Daniel Quilca**: Entidad `Libro` (CRUD completo)
* **Nancy Defaz**: Entidad `Materia` (CRUD completo)

---

##  Requisitos del Sistema
* Visual Studio 2022 / 2026
* .NET 10 SDK
* SQL Server Express / LocalDB

---

##  Pasos para ejecutar el proyecto en local

1. **Clonar el repositorio:**
bash
git clone https://github.com/AlfredoLapo/GestionEscolar.git

2. **Configurar la cadena de conexión:**
Verificar o agregar la cadena de conexión en el archivo `appsettings.json` apuntando a tu instancia local de SQL Server / LocalDB:

json
"ConnectionStrings": {
"GestionEscolarContext": "Server=(localdb)\mssqllocaldb;Database=GestionEscolar;Trusted_Connection=True;MultipleActiveResultSets=true"
}

3. **Crear y actualizar la Base de Datos:**
Abrir la **Consola del Administrador de Paquetes NuGet** en Visual Studio (`Herramientas` > `Administrador de paquetes NuGet` > `Consola del Administrador de paquetes`) y ejecutar:

powershell
Update-Database











