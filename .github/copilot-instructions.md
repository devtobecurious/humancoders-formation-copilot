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

## � Conventions de Commit

Tous les messages de commit doivent suivre le format **Conventional Commits** :

### Format

```
<type>: <description en anglais>
```

### Types principaux

- **feat:** Nouvelle fonctionnalité
  ```
  feat: add player authentication system
  feat: implement score calculation algorithm
  ```

- **chore:** Tâches techniques (configuration, dépendances, etc.)
  ```
  chore: update NuGet packages
  chore: configure logging middleware
  ```

- **fix:** Correction de bug
  ```
  fix: resolve null reference in GameSession
  ```

- **docs:** Documentation
  ```
  docs: update API documentation
  ```

- **refactor:** Refactorisation du code
  ```
  refactor: simplify score calculation logic
  ```

- **test:** Ajout ou modification de tests
  ```
  test: add unit tests for PlayerRepository
  ```

- **style:** Formatage du code (sans changement fonctionnel)
  ```
  style: apply consistent indentation
  ```

## �📋 Règles Supplémentaires

- Utiliser les conventions C# (.NET 9.0) pour ce projet
- Privilégier les patterns asynchrones (async/await)
- Respecter les principes SOLID
- Appliquer le style Minimal API pour les endpoints


-- Feature creation workflow 

When creating a new feature, follow this structured workflow:

Ask for feature title
Ask for feature content/description
Ask for expected outcomes
Ask for acceptance criteria IMPORTANT: Always validate the object structure before proceeding
Create dedicated branch for the feature (wait for approval)
List all planned steps in .steps.md file
Make conventional commits at each step completion
Complete code review after all steps IMPORTANT: Iterate until code builds and is CLEAN
Ensure code is functional and clean
Wait for approval before merging to main branch