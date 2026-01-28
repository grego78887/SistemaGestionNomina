# Sistema de Gestión de Nómina

Sistema de gestión de nómina desarrollado en Windows Forms con .NET

![Build Status](https://github.com/grego78887/SistemaGestionNomina/workflows/Build%20Windows%20Forms%20App/badge.svg)

## 📋 Requisitos Previos

Antes de compilar el proyecto, asegúrate de tener instalado:

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) (o la versión correspondiente)
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) (Community Edition es gratis)
  - Con la carga de trabajo ".NET desktop development"
- O [Visual Studio Code](https://code.visualstudio.com/) con la extensión de C#

## 🚀 Cómo Compilar el Proyecto

### Opción 1: Usando Visual Studio

1. **Clona el repositorio**:
   ```bash
   git clone https://github.com/grego78887/SistemaGestionNomina.git
   cd SistemaGestionNomina
   ```

2. **Abre el proyecto**:
   - Doble clic en `SistemaGestionNomina.sln`
   - Visual Studio se abrirá automáticamente

3. **Compila el proyecto**:
   - Presiona `Ctrl + Shift + B` o
   - Ve a `Build > Build Solution`

4. **Ejecuta la aplicación**:
   - Presiona `F5` o
   - Ve a `Debug > Start Debugging`

### Opción 2: Usando la línea de comandos

1. **Clona el repositorio**:
   ```bash
   git clone https://github.com/grego78887/SistemaGestionNomina.git
   cd SistemaGestionNomina
   ```

2. **Restaura las dependencias**:
   ```bash
   dotnet restore
   ```

3. **Compila el proyecto**:
   ```bash
   dotnet build --configuration Release
   ```

4. **Ejecuta la aplicación**:
   ```bash
   dotnet run --project SistemaGestionNomina/SistemaGestionNomina.csproj
   ```

## 📦 Generar Ejecutable

Para crear un archivo `.exe` independiente:

```bash
dotnet publish SistemaGestionNomina/SistemaGestionNomina.csproj -c Release -r win-x64 --self-contained true -o ./output
```

El ejecutable estará en la carpeta `output/`

**Nota**: El ejecutable auto-contenido incluye el runtime de .NET completo, por lo que el tamaño será mayor (100+ MB). Si deseas un ejecutable más pequeño y sabes que .NET está instalado en el sistema destino, usa `--self-contained false`.

## 🔄 Sincronizar Cambios con GitHub

**⚠️ Importante**: Los cambios que hagas en Visual Studio **NO** se reflejan automáticamente en GitHub. Debes seguir estos pasos para subir tus cambios:

### Opción 1: Usando Visual Studio

1. **Ver cambios realizados**:
   - Ve a `View > Git Changes` (o presiona `Ctrl + 0, Ctrl + G`)
   - Verás la lista de archivos modificados

2. **Hacer commit de tus cambios**:
   - En la ventana "Git Changes", revisa los archivos modificados
   - Escribe un mensaje descriptivo del commit (ejemplo: "Agregada validación de datos")
   - Haz clic en el botón **Commit All**

3. **Subir cambios a GitHub (Push)**:
   - Después del commit, haz clic en el botón **Push** (flecha hacia arriba)
   - Tus cambios ahora estarán en GitHub

4. **Descargar cambios de GitHub (Pull)**:
   - Si hay cambios nuevos en GitHub que no tienes localmente
   - Haz clic en el botón **Pull** (flecha hacia abajo)
   - Esto descargará los últimos cambios del repositorio

### Opción 2: Usando la línea de comandos

1. **Ver el estado de los cambios**:
   ```bash
   git status
   ```

2. **Agregar archivos al commit**:
   ```bash
   # Agregar todos los archivos modificados
   git add .
   
   # O agregar archivos específicos
   git add nombre-del-archivo.cs
   ```

3. **Hacer commit con un mensaje descriptivo**:
   ```bash
   git commit -m "Descripción clara de los cambios realizados"
   ```

4. **Subir cambios a GitHub**:
   ```bash
   git push origin master
   ```

5. **Descargar cambios de GitHub**:
   ```bash
   git pull origin master
   ```

### 💡 Buenas Prácticas

- **Commits frecuentes**: Haz commits pequeños y frecuentes con cambios relacionados
- **Mensajes claros**: Usa mensajes descriptivos que expliquen QUÉ y POR QUÉ cambiaste algo
  - ✅ Bueno: "Agregada validación de email en el formulario de empleados"
  - ❌ Malo: "Cambios" o "Update"
- **Pull antes de Push**: Siempre descarga los cambios más recientes (`pull`) antes de subir los tuyos (`push`)
- **Revisa antes de commit**: Verifica que solo estás subiendo los archivos necesarios

### 🆘 Problemas Comunes

**"Rejected - non-fast-forward"**: 
- Alguien más subió cambios a GitHub
- Solución: Primero haz `git pull`, resuelve conflictos si hay, luego `git push`

**Conflictos de fusión**:
- Ocurre cuando tú y otra persona modificaron las mismas líneas
- Visual Studio te ayudará a resolverlos mostrándote ambas versiones
- Elige qué cambios mantener y luego haz commit

## 🛠️ Tecnologías Utilizadas

- .NET (Windows Forms)
- C#

## 👥 Autor

grego78887

## 📐 Diagrama de caso de uso

<img width="1024" height="559" alt="image" src="https://github.com/user-attachments/assets/f302d1d8-06fb-41fc-b03f-fd1b2db30ba3" />
