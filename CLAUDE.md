# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Repository Overview

This is an IoT/.NET developer training repository (IoT 개발자 닷넷) covering C# basics through applied projects. It contains multiple independent solutions organized by learning progression, not a single unified application.

## Solution Structure

```
basic/         - C# console apps (syntax, collections, exceptions, OOP)
winapp/        - Windows desktop apps (WinForms + WPF)
webapp/        - Web apps (ASP.NET Core MVC + Web API)
wpf/           - WPF practice projects (Cafe Kiosk)
unity/         - Unity game engine projects
```

All projects target **.NET 10.0**. Windows desktop projects (`net10.0-windows`) use either `UseWindowsForms` or `UseWPF`.

## Build & Run Commands

Each project has its own `.slnx` (Visual Studio solution) file. Open the relevant `.slnx` in Visual Studio to build and run.

From the CLI, navigate into a project directory and run:

```bash
dotnet build          # build the project
dotnet run            # run (console/web apps)
dotnet build -c Release  # release build
```

For WinForms/WPF apps, use Visual Studio (F5 to run, Ctrl+Shift+B to build) since they require a windowed environment.

## Project Map

| Folder | Solution | Type | Key NuGet Packages |
|--------|----------|------|--------------------|
| `basic/Ex01_basic/` | `Ex01_basic.slnx` | Console apps | — |
| `winapp/DotNet01/` | `DotNet01.slnx` | WinForms | — |
| `winapp/DotNet03GuessNum/` | `DotNet03GuessNum.slnx` | WinForms | MaterialSkin.2, MySqlConnector |
| `winapp/IoTWpfSolution/` | `IoTWpfSolution.slnx` | WPF | — |
| `winapp/WpfApp1/` | `WpfApp1.slnx` | WPF | MahApps.Metro, MahApps.Metro.IconPacks |
| `winapp/WpfUIAPP03/` | `WpfUIAPP03.slnx` | WPF | MahApps.Metro, MahApps.Metro.IconPacks |
| `webapp/APS.NET01/` | `APS.NET01.slnx` | ASP.NET Core MVC | — |
| `webapp/DotNetWebApp/` | `DotNetWebApp.slnx` | ASP.NET Core Web API | — |
| `wpf/WpfPracticeSolution/` | `WpfPracticeSolution.slnx` | WPF Kiosk | MaterialDesignThemes, MahApps.Metro.IconPacks, MySqlConnector |

## Architecture Patterns

### WPF Projects
- XAML for UI, code-behind (`.xaml.cs`) for event handlers
- `Models/` folder holds data model classes (e.g., `MenuItem.cs`, `OrderItem.cs`)
- `ObservableCollection<T>` binds lists to UI controls
- `Window.ShowDialog()` for modal popups; `Owner = this` wires up parent-child relationship
- Button `Tag` property used to pass multiple data values (pipe-delimited: `MenuName|Price|ImagePath`)

### ASP.NET Core MVC (`APS.NET01`)
- Standard MVC: `Controllers/` → `Models/` → `Views/*.cshtml` (Razor)
- `Program.cs` is the entry point; registers services and configures middleware pipeline
- Route pattern: `{controller=Home}/{action=Index}/{id?}`
- Static assets served from `wwwroot/`

### ASP.NET Core Web API (`DotNetWebApp`)
- Controller-only (no views); `[ApiController]` + `[Route("[controller]")]`
- Returns JSON; no Razor views

### WinForms Projects
- Forms (`Frm*.cs`) with Designer-generated `*.Designer.cs`
- `Program.cs` bootstraps with `Application.Run(new FrmMain())`

## Database (MySQL)

Projects using MySQL connect via **MySqlConnector** NuGet package. The Cafe Kiosk schema:

```sql
-- cafekiosk database
CREATE TABLE menu (menu_id INT PK AUTO_INCREMENT, menu_name, price, image_path, category, is_sale CHAR(1) DEFAULT 'Y');
CREATE TABLE orders (order_id INT PK AUTO_INCREMENT, order_date DATETIME, total_count INT, total_amount INT);
CREATE TABLE order_detail (detail_id INT PK AUTO_INCREMENT, order_id FK→orders, menu_id, menu_name, price, count, total_price);
```

DB connection strings are managed in a `DatabaseHelper` class (not `appsettings.json`) in desktop apps.

## Key Conventions

- All projects use `ImplicitUsings` and `Nullable enable` — no explicit `using` blocks needed for common BCL types.
- WPF image resources are declared as `<Resource>` in `.csproj` and accessed via pack URIs.
- Debug logging in WPF: change Output Type to "Console Application" in project properties to enable `Console.WriteLine()` output during development; switch back to "Windows Application" before release.
- Release builds: Configuration Manager → switch Debug → Release before final build/deploy.
