# Instructions Copilot - Projet HumanCoders

## 🗣️ Langue de Communication

- **Réponses et explications** : Toujours en **français**
- **Code et documentation technique** : En **anglais**

## 💻 Conventions de Code

### Nommage (toujours en anglais)

- **Variables** : camelCase en anglais
  ```csharp
  int playerScore = 0;
  string userName = "John";
  ```

- **Fonctions/Méthodes** : PascalCase en anglais
  ```csharp
  public void CalculateScore() { }
  public async Task<GameSession> GetSessionById(int id) { }
  ```

- **Classes** : PascalCase en anglais
  ```csharp
  public class GameSession { }
  public class PlayerRepository { }
  ```

- **Interfaces** : PascalCase avec préfixe 'I' en anglais
  ```csharp
  public interface IGameService { }
  public interface IPlayerRepository { }
  ```

### Commentaires et Documentation

- **Commentaires inline** : En anglais
  ```csharp
  // Calculate the total score based on game duration
  ```

- **Documentation XML** : En anglais
  ```csharp
  /// <summary>
  /// Calculates the final score for a game session
  /// </summary>
  /// <param name="sessionId">The unique identifier of the session</param>
  /// <returns>The calculated score</returns>
  ```

## 🔄 Flux de Travail

Avant toute action demandée par l'utilisateur :

1. **Lister les instructions applicables** : Afficher les règles qui seront suivies pour la tâche demandée
2. **Attendre confirmation** : Attendre explicitement le "go" de l'utilisateur avant d'exécuter

### Exemple de flux

```
Utilisateur : "Crée une classe pour gérer les joueurs"

Copilot : 
Instructions à suivre :
- Créer une classe en anglais (PlayerManager)
- Commenter le code en anglais
- Variables et méthodes en anglais
- Répondre en français

Attendez-vous le go pour procéder ? 🚦

Utilisateur : "go"

Copilot : [Exécute la création]
```

## 📋 Règles Supplémentaires

- Utiliser les conventions C# (.NET 9.0) pour ce projet
- Privilégier les patterns asynchrones (async/await)
- Respecter les principes SOLID
- Appliquer le style Minimal API pour les endpoints
