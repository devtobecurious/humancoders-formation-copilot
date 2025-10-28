---
description: Instuctions for units tests and quality tests
applyTo: '/tests/quality-tests/**'
---
# 🧪 Instructions pour les Tests de Qualité
## Objectif
L'objectif de ces instructions est de guider la création et l'exécution de tests de qualité pour assurer que le code respecte les normes de qualité définies.

## 📚 Règles de Codage pour les Tests de Qualité
### Langue
- **Langue principale** : Anglais
- **Réponses aux utilisateurs** : Français
### Nommage
- **Classes de test** : Suffixer avec "Tests" (e.g., UserServiceTests)
  ```csharp 
    public class UserServiceTests { }
    ``` 
- **Méthodes de test** : Décrire le scénario testé en utilisant la convention `MethodName_StateUnderTest_ExpectedBehavior`
  ```csharp
    public void CalculateScore_ValidInput_ReturnsCorrectScore() { }
    public async Task GetSessionById_NonExistentId_ThrowsNotFoundException() { }
  ```
