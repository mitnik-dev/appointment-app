# appointment-app

A Windows Forms appointment management system built with C# .NET 8.0 and MySQL. Features appointment scheduling, customer management, business hours validation, overlap detection, and comprehensive reporting backed by custom SQL handling for fine-grained control over queries and transactions.

## Highlights
- MySQL data layer uses hand-written SQL so every repository method can tune joins, filtering, and locking for predictable performance.
- Localization-ready UI with resource files and culture-aware validation.
- Modular architecture separating core models, data access, and WinForms presentation.
- Built for WGU C969 requirements with extendable reporting and auditing hooks.
