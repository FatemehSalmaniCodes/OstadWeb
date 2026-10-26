# 🎓 OstadWeb

> A hands-on **ASP.NET Web Forms** project built step by step in class, with a tiny online shop as the playground.

![ASP.NET](https://img.shields.io/badge/ASP.NET-Web%20Forms-512BD4?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-.NET%204.5.2-239120?logo=csharp&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-Database-CC2927?logo=microsoftsqlserver&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.3-7952B3?logo=bootstrap&logoColor=white)

---

## 👨‍🏫 Credits

This repository and all of its original material belong to **Dr. Forghani**
([@Shahabforghani](https://github.com/Shahabforghani)), our professor at the university.

📝 We only make small updates to the files after each session, so the code stays in sync with the class
and anyone who missed a note or a photo of the board can catch up.

---

## ✨ What's inside

A small shop where you can list products, search them, add new ones with an image, and see their details.

| Page | What it does |
| --- | --- |
| `Default.aspx` | Home page (uses the master page) |
| `List.aspx` | Product cards with a filter sidebar (RTL, Bootstrap) |
| `Product_list.aspx` | Demo: sending an ID with **QueryString** vs **Session** |
| `Product_dtl.aspx` | Product detail page, shows the received ID |
| `search_frm.aspx` | Search by name or ID, results in a GridView |
| `Item_mng.aspx` | Add an item (name + price) |
| `Upload_form.aspx` | Add an item with an **image upload** |
| `AdminPanel/` | Empty admin area, ready for later sessions |

---

## 🗂️ Project structure

```
MyWeb/
├── AdminPanel/      → admin pages (placeholder)
├── assets/css/      → Bootstrap 5.3.8
├── CLS/             → data layer (connection.cs, item.cs)
├── upload/          → uploaded product images
├── MS1.Master       → shared layout (menu, content, footer)
├── *.aspx / *.cs    → pages and their code-behind
└── Web.config       → site configuration
```

---

## 🚀 Getting started

1. Install **Visual Studio** with the *ASP.NET and web development* workload.
2. Install **SQL Server** (Express or LocalDB works) on your machine.
3. Create a database named **`shop`** with a table **`item_tbl`**. Example:

   ```sql
   CREATE TABLE item_tbl (
       ItemID  INT IDENTITY(1,1) PRIMARY KEY,
       ItmName NVARCHAR(100),
       Iprice  INT,
       Iimg    NVARCHAR(250)
   );
   ```

4. Open `MyWeb.sln`, restore the NuGet packages, and press **F5** to run.

> The connection string lives in `CLS/connection.cs` and uses `Data Source=.` with Windows authentication.
> Change it there if your SQL Server instance has another name.

---

## 📚 Topics covered so far

- 🧱 Master pages and content placeholders
- 🔗 Passing data between pages: QueryString, Session, `Server.Transfer`
- 🗃️ Connecting to SQL Server with `SqlConnection` and `SqlDataAdapter`
- 🧾 Data-bound controls: `ListView` and `GridView`
- 📤 File upload with `FileUpload`
- 🎨 Bootstrap cards, grid and buttons

---

## 🛠️ Notes

- Some SQL is built from user input on purpose for teaching. **Do not use it as-is in a real project**;
  switch to parameterized queries (`SqlParameter`) first.
- The project is a learning playground and will keep growing session by session. 🌱

---

<p align="center">Made for learning 💜 &nbsp;|&nbsp; Original work by Dr. Forghani &nbsp;|&nbsp; Notes by C.E Students 🤍</p>

