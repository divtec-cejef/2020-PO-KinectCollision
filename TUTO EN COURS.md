# Création du projet
* Lancer Unity Hub
* Créer un nouveau projet 3D
* Une fois le projet créé, il devrait s'ouvrir
* Directement aller dans "Edit" > "Preferences..."
* Dans l'onglet "External Tool", choisir "Visual studio 2019 (community)" pour "External script editor", celà permet a Visual Studio d'intégrer des fonctions/complétions de Unity

    ![GitHub Logo](/img/External_tools.png)
* Télécharger puis importer le [package pour kinect](https://assetstore.unity.com/packages/3d/characters/kinect-v2-examples-with-ms-sdk-18708 "Package Kinect")
    
    **La création du projet est terminée**

# Projet HelloWorld
## Ajouter un squelette

Il faut récupérer le squelette présent dans la démo du package précédement installé en ouvrant la scene "KinectAvatarsDemo4" présente dans Assets > K2Exemples > KinectDemos > AvatarsDemo

![Pscreen de kinectAvatarDemo4](/img/KinectAvatarsDemo4.png)

Copier l'objet "KinectController" et le coller dans votre scène (pour revenir à votre scene de départ > File > Open Scene > Scenes > SampleScene.unity)
Pour ajouter un personnage a votre squelette, cliquez sur l'objet "KinectController", dans le script "User Avatar Matcher" séléctionnez le personnage voulu dans "Avatar Model" (ici je choisis "Robot")

![Pscreen choix du skin](/img/choisirSkin.png)

Double-cliquez sur l'élément Robot dans "Avatar Model" pour trouver sa source et glissez le dans votre hiérarchie

![Pscreen hiérarchie](/img/elementhierarchie.png)

Ce nouvel object Robot vous permettra de gérer les futures collisions.
Vous pouvez le rendre invisible en décochant la case à côté de son nom pour évitez qui vous dérange lors des phase de jeu

![Pscreen décocher object](/img/uncheck.png)

Si vous lancer votre projet, un personnage reproduisant vos mouvements devrait maintenant apparaître.

## Créer les objets

Pour cet exemple vous allez créez deux cubes de couleur bleu, dès que une des mains du joueur entre en contact avec un des cube, il devient rouge, et s'il enlève sa main, il redevient bleu.

Créez un cubes (Clique droit dans la hérarchie > new 3D object > 3D Cube)

Sélectionnez votre cube et dans l'inspecteur, cliquez sur "Add Component" > Box Collider et cochez "is Trigger" pour le définir comme "déclanché"

![Pscreen boxCollider component](/img/boxcollider.png)

Dans le dossier "Assets", créez un nouveau dossier "Material", il contiendra les deux couleurs que le cube peu avoir.

Clique droit dans le dossier "Material" > Create > Material, donnez lui une couleur bleu.

Dupliquez le matérial bleu puis donnez lui la couleur rouge (n'oubliez pas de bien renommer vos nouveau material !).

Glissez votre nouveau material bleu sur votre cube précédemment créé, puis dupliquez votre cube.

Vous avez maintenant deux cubes bleus, un sera à gauche, un à droite.

![Pscreen deux cubes bleus](/img/checkpoint1.png)

vous allez ensuite donner un box collider au deux poignet du Robot

pour ce faire, sélectionner le poignet (wrist) du Robot et Add component > Box Collider.

![Pscreen wrist du robot](/img/robotwrist.png)

Ajoutez également un RigidBody (décochez use gravity et cochez is Kinematic).

![Pscreen rigidBody component](/img/rigid.png)

**Création des objets terminée**

## Gérer les collisions

Avant de gérer les collisions il faut comprendre les collisions !

Les cubes sont des "déclancheurs" (il font quelque chose s'ils sont touché ou non).

Tout ça se gère via un script.

Dans votre dossier "Assets", clique-droit > create > C# script et nommez-le "collision".

Ouvrez-le (il devrait s'ouvrir avec visual studio !).

Supprimez les fonction Start et Update.

Créez deux variables qui représenteront les deux coloris des cubes :

```C#
using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

//Gère les collisions entre le personnage et les objets présents
public class Collisions : MonoBehaviour   
{
    public Material rouge;
    public Material bleu;
}
```

Créez deux fonctions, une "OnTriggerEnter" et une "OnTriggerExit" avec comme paramètre (Collider cube).

La fonction Enter détecte quand une collision se produit, la fonction Exit détecte quand la collision s'arrête.


```C#
private void OnTriggerEnter(Collider cube)
    {
        
    }

    private void OnTriggerExit(Collider cube)
    {

    }
```

Le paramètre cube référence le box collider du cube qui sera touché.

Dans la fonction OnTriggerEnter, nous allons changer la couleur du cube en rouge.

On récupère pour ça le l'objet du collider détecté par la collision (donc le cube) pour pouvoir modifié son paramètre Material

On attribue notre Material rouge au material du cube.

```C#
private void OnTriggerEnter(Collider cube)
    {
        GameObject gameObjectCube = cube.gameObject;
        gameObjectCube.GetComponent<Renderer>().material = rouge;
    }
```

Et lorsque la collision s'arrête, on remplace le Material du cube par notre Material bleu.

```C#
private void OnTriggerExit(Collider cube)
    {
        GameObject gameObjectCube = cube.gameObject;
        gameObjectCube.GetComponent<Renderer>().material = bleu;
    }
```

Maintenant il faut faire le lien entre vos deux variables Material et vos deux Material.

Pour se faire : sauvegarder votre script (CTRL+S) puis fermer visual studio.

Sélectionnez votre script, deux paramètres sont maintenant disponnibles pour votre script : bleu et rouge.

![Pscreen nouveau param script](/img/scriptparam.png)

Glissez ce script sur le Left_Wrist du robot, lorsque vous sélectionnez Left_Wrist du robot, le script devrait apparaître dans l'inspector.

Glissez maintenant vos Material bleu et rouge dans les paramètre bleu et rouge du script collision présent sur Left_Wrist du robot.

![Pscreen param du script rempli](/img/paramscript.png)

Faite exactement la même chose pour le Right_Wrist du robot.

**Gestion des collisions terminée**

Il vous suffit maintenant de lancer le projet pour essayer de toucher les cubes.

Il faudra sûrement déplacer les cubes pouvoir être capable de les atteindre.