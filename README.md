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

## 🛠️ Tecnologías Utilizadas

- .NET (Windows Forms)
- C#

## 👥 Autor

grego78887

## 📐 Diagrama de caso de uso

<img width="1024" height="559" alt="image" src="https://github.com/user-attachments/assets/f302d1d8-06fb-41fc-b03f-fd1b2db30ba3" />
