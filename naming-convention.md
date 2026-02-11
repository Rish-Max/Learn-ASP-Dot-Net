# C# Naming Conventions (Quick Guide)

## ✅ PascalCase

Used for:

- Classes → `OrderService`
- Methods → `CalculateTotal()`
- Properties → `FirstName`
- Enums → `OrderStatus`
- Enum Members → `PendingApproval`
- Constants → `MaxRetryCount`

---

## ✅ camelCase

Used for:

- Variables → `totalAmount`
- Method Parameters → `userId`

---

## ✅ Private Fields

Use underscore + camelCase:

    private readonly IUserRepository _userRepository;

---

## ✅ Interfaces

Prefix with `I`:

    public interface ILogger

---

## ✅ Async Methods

Add `Async` suffix:

    GetUserAsync()

---

## ✅ Boolean Naming

Use readable prefixes:

- `isActive`
- `hasPermission`
- `canEdit`

---

## 🚀 Key Rules

- Use meaningful names (`invoiceTotal`, not `x`)
- Avoid abbreviations (`UserService`, not `UsrSvc`)
- Use singular class names (`User`, not `Users`)
- Maintain consistency across the project
