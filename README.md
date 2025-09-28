# 🧮 Calculator MVC Application

This repository contains an **ASP.NET Core MVC** web application that implements a simple yet extendable **Calculator**.  
The project is built using the **Model-View-Controller (MVC)** architecture and is designed for deployment and hosting on **Microsoft Azure**.

---

## 🌍 Purpose

- 🧩 Demonstrate usage of **MVC pattern** in ASP.NET Core  
- 🧮 Provide a functional calculator with basic arithmetic operations  
- ☁️ Integrate application with **Azure App Service** for cloud deployment  
- 🚀 Serve as an example of CI/CD pipeline from GitHub → Azure  

---

## 🛠 Tech Stack

- **Backend**: ASP.NET Core MVC (.NET 6/7/8)  
- **Frontend**: Razor Views + Bootstrap (for UI)  
- **Language**: C#  
- **Cloud**: Microsoft Azure (App Service, optional Azure SQL)  
- **DevOps**: GitHub Actions + Azure CLI  

---

## 🔄 Architecture

```mermaid
flowchart TD
    M[Model: Calculator Logic] --> C[Controller: CalculatorController]
    C --> V[View: Razor Pages]
    V --> U[User Input / Interaction]
    U --> C
