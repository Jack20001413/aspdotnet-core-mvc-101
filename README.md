# aspdotnet-core-mvc-101

This repo is where I practice ASP.NET core MVC

## Install EF tool

By default, `dotnet` CLI doesn't include tool to work with EF core for Linux, so you must install the tool by yourself manually.

To install the EF tool globally.

```bash
dotnet tool install --global dotnet-ef
```

Verify the tool using.

```bash
dotnet ef --version
```

## ERD

```mermaid
---
title: Inventory Management System
---
erDiagram
    PurchaseOrder ||--|{ PurchaseOrderDetails: has
    Ingredient ||--|{ PurchaseOrderDetails: buy
    Supplier ||--|{ PurchaseOrder: supply
    Warehouse ||--|{ PurchaseOrder: deliver
    Ingredient {
        int id PK
        string name
        string sku
        float quantity
        datetime created_at
        datetime updated_at
    }
    Supplier {
        int id PK
        string name
        string address
        datetime created_at
        datetime updated_at
    }
    PurchaseOrder {
        int id PK
        int order_number
        date creation_date
        string order_person
        int warehouse_id FK
        int supplier_id FK
        datetime created_at
        datetime updated_at
    }
    PurchaseOrderDetails {
        int order_id PK,FK
        int ingredient_id PK,FK
        int quantity
        string sku
        datetime created_at
        datetime updated_at
    }
    Warehouse {
        int id PK
        string address
        string person_in_charge
        datetime created_at
        datetime updated_at
    }
```
