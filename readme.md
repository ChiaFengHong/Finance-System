# 💰 Finance-System

**家庭收支管理系統**  
可以用在 Windows、iPhone、iPad，跨平台操作，方便管理日常收入與支出。  
架構採 **Clean Architecture / 分層架構**，未來可擴充 POS / 出單 / 錢櫃功能。

---

## 🏗 專案架構

```plaintext
Finance-System/
 ├── src/
 │   ├── Finance.Domain/           # 資料模型（Entities、Enums）
 │   ├── Finance.Application/      # 商業邏輯層（Services、Interfaces）
 │   ├── Finance.Infrastructure/   # 資料存取層（DbContext、Repositories）
 │   ├── Finance.API/              # Web API 層
 │   └── Finance.Web/              # 前端 MVC 或 WPF / Blazor UI
 └── tests/
     └── Finance.Application.Tests/  # 單元測試
```
* Application → Domain
* Infrastructure → Application + Domain
* API → Infrastructure + Application
* Web → API
* Tests → Application

---

⚡ 功能
* 新增收入/支出紀錄
* 查詢所有紀錄
* 按類別、日期篩選
* 可擴充 POS / 出單 / 錢櫃功能

---

💻 技術棧
* C# / .NET 8
* ASP.NET Core Web API
* Entity Framework Core（SQL Server）
* XUnit（單元測試）
* 可選：WPF / MAUI / Blazor Web 前端

 ---

🛠 安裝與執行
1. Clone 專案
```
git clone https://github.com/你的帳號/Finance-System.git
cd Finance-System
```
2. 打開 Solution
```
Finance-System.sln
```
3. 建立資料庫與 Migration（Finance.API 專案為啟動專案）
```
cd src/Finance.API
dotnet ef database update --startup-project Finance.API --project ../Finance.Infrastructure
```
4. 啟動 API
* Visual Studio → 選擇 Finance.API → Debug → Run
* Swagger 頁面會自動生成，可以測試 API
5. 可選：啟動前端 UI (Finance.Web)

---

🧪 單元測試
```
cd tests/Finance.Application.Tests
dotnet test
```
---

🔧 專案特色
* 分層架構：Domain / Application / Infrastructure / API / Web
* 易擴充：未來可加入 POS、出單、錢櫃控制功能
* 乾淨依賴：透過 Interface 解耦 Application 與 Infrastructure
* 版本管理：使用 Git + GitHub

---

📌 注意事項
* 修改資料庫連線字串：Finance.API/Program.cs
* Migration 只需在 Infrastructure 專案執行
* 本專案適合個人家庭收支管理，也可擴充小型商店收支系統
