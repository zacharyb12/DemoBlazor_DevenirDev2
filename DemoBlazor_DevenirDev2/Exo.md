# Exercice Blazor

## Création d'une app

# Model : Service

```csharp
    public class Service
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public DateTime DateService { get; set; }

        public string Informations { get; set; }

        public   string ImageUrl { get; set; }

        public bool Actif { get; set; }

        public int AccompagnateurId { get; set; }

        public List<string> Participants { get; set; } = new();
    }


```

## Crud Service

- Ajout d'un service : AccompagnateurID fictif
- Recupération d'un service : Id
- Modification d'un service : Id et modèle
- Suppression d'un service : Id

## Affichage

- Liste Des services : Permettre 
- Ajout d'un service : AccompagnateurID en dur
- Modification : Un Boutton pour modifier le status , ou permettre de modifier le contenu
- Suppression : Sur la page update ajouter un boutton suppression
- Homepage : Présentation de projet 