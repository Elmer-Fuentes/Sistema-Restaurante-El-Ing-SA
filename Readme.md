
# 📘 Proyecto Final – Programación III  
**Sistema de Gestión para Restaurante "El Inge S.A."**  
**Universidad Mariano Gálvez – Centro Universitario Cuilapa, Santa Rosa**  
**Curso:** Programación III  
**Docente:** Ing. Elvis Morales  
**Fecha:** 01 de junio de 2025  

---

## 👥 Integrantes del Proyecto

- **David Estuardo Cruz García** – 7490-23-22484  
- **Elmer Leonel de la Cruz Fuentes** – 7490-23-23907  
- **Edgar Josué López Arévalo** – 7490-23-5979  

---

## 🧾 Descripción General del Proyecto

El proyecto consiste en el desarrollo de un sistema integral para la cadena de restaurantes **"El Inge S.A."**, que busca reemplazar su sistema manual basado en hojas de cálculo por una solución digital que:

- Optimiza la gestión operativa.
- Mejora el control de pagos.
- Proporciona una interfaz gráfica amigable.
- Asegura la integridad y seguridad de la información.
- Incluye todo el código fuente en C#, el archivo de reportes en Power BI (PBI) y la solución completa del proyecto en SQL Server, con todos sus scripts correspondientes.

---

## 🧩 Arquitectura del Sistema

### 🔹 Capa de Presentación

Formularios desarrollados para gestionar:

- **Empleados**
- **Usuarios**
- **Clientes**
- **Mesas**
- **Menús**
- **Encabezado y Detalles de Órdenes**
- **Pago de Órdenes**
- **Inventarios**
- **Pago de Planillas**
- **Menú de Navegación**

Cada formulario incluye validaciones, listas desplegables, calendarios y valores fijos para facilitar la interacción del usuario.

---

### 🔹 Capa Lógica

Contiene métodos para:

- Cálculo de salarios, precios, impuestos, propinas y descuentos.
- Validaciones de datos.
- Lógica de negocio para cada entidad del sistema.

---

### 🔹 Capa de Datos

Incluye clases y métodos para:

- Conexión a la base de datos.
- CRUD (Crear, Leer, Actualizar, Eliminar) para todas las tablas del sistema.

---

### 🔹 Capa de Seguridad

- Implementación del formulario de login.
- Métodos de autenticación y conexión segura a la base de datos.

---

## 🧠 Aportes por Integrante

### 👨‍💻 David Estuardo Cruz García

**Formularios desarrollados:**

- Clientes
- Mesas
- Inventarios

**Aportes:**

- Métodos específicos para cada formulario.
- Funciones de búsqueda personalizada.
- Programación de la lógica de negocio.
- Conexión y manejo de la capa de datos.
- Organización estructurada de todas las capas.

---

### 👨‍💻😎 Elmer Leonel de la Cruz Fuentes

**Formularios desarrollados:**

- Menú
- Detalles de Órdenes
- Pago de Órdenes
- Usuarios

**Aportes:**

- Desarrollo del login del sistema.
- Formulario principal del menú.
- Implementación de la capa de seguridad y entidades.
- Creación de modelos de datos por medio de SQL para PBI. 
- Reportes en Power BI para analisis de datos.
- Reportes con opciones para exportar a Word, Excel y PDF.
- Controlador de impresora.
- Buscador de empleados sin usuario.
- Uso de procedimiento almacenados en Sql Server.
- Diagrama de relaciones, SQL  server - PostgreSQL. 
- Administración de la base de datos en Azure.

---

### 👨‍💻 Edgar Josué López Arévalo

**Formularios desarrollados:**

- Empleados
- Pago de Planillas
- Encabezado de Órdenes

**Aportes:**

- Métodos en la capa lógica y de datos.
- Validaciones en formularios (errores, campos vacíos).
- Aplicación de validaciones en formularios de otros compañeros.
- Redacción del informe final del proyecto.

---

## 📊 Herramientas y Tecnologías Utilizadas

- **C# / .NET Framework**
- **SQL Server / Azure**
- **Power BI**
- **Visual Studio**
- **Diseño por capas (Presentación, Lógica, Datos, Seguridad,Entidades)**
