# Partie 1 : Le Modèle de Données
Créez une classe Service dans un dossier Models :

C#
public class Service
{
    public int Id { get; set; }
    public string Type { get; set; } // Ex: Transport, Aide à domicile, Soins
    public DateTime DateService { get; set; }
    public string Informations { get; set; }
    public string ImageUrl { get; set; }
    public bool Actif { get; set; }
    public int AccompagnateurId { get; set; }
    public List<string> Participants { get; set; } = new();
}

# Partie 2 : Logique Métier (CRUD)
Créez un service Blazor (ServiceService.cs et IService) qui gère une liste en mémoire (List<Service>) avec les méthodes suivantes :

Create : Ajoute un service (générer l'Id automatiquement).

GetAll : Retourne la liste complète.

GetById : Récupère un service spécifique via son Id.

Update : Met à jour les propriétés d'un service existant.

Update : Met à jour le status d'un service existant.

Delete : Supprime un service de la liste via son Id.

# Partie 3 : Interface Utilisateur (UI)
1. Page d'accueil (Index.razor)
Présentation textuelle du projet.

Un bouton de navigation rapide vers la liste des services.

2. Liste des Services
Affichage sous forme de Tableau ou de Cards.

Afficher l'image (ImageUrl), le type et la date.

Optionnel : Ajouter une barre de recherche pour filtrer par Type.

3. Formulaire d'Ajout & Modification
Utilisation du composant <EditForm> avec validation simple.

Ajout : Le AccompagnateurId peut être saisi en dur (ex: 1) par défaut.

Modification :

Possibilité de modifier toutes les informations.

Ajouter un bouton spécifique "Toggle Status" pour activer/désactiver le service (Actif true/false).

4. Suppression
Ajouter un bouton de suppression sur la page de modification ou directement dans la liste (avec une boîte de dialogue de confirmation).

# Bonus (Pour aller plus loin)
Validation : Utiliser les DataAnnotations ([Required], [StringLength]).

Design : Utiliser Bootstrap ou css.

Filtre temps réel : Implémenter la recherche automatique à la saisie (événement @oninput).

