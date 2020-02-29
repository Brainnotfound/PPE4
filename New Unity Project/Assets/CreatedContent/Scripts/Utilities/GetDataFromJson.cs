﻿using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class GetDataFromJson
{
    #region properties
    public string JsonContent { get; private set; }

    private readonly string pathToJsonData = "Assets/CreatedContent/Data/ObjectsData.json";
    #endregion

    #region Constructor
    public GetDataFromJson()
    {
        setJsonContent();
    }
    #endregion

    /// <summary>
    /// Attribution des ressources JSON à JsonContent
    /// </summary>
    public void setJsonContent()
    {
        // Crée un reader à partir du chemin vers le fichier de ressources du projet
        StreamReader jsonReader = new StreamReader(pathToJsonData);

        // Applique le contenu du reader à JsonContent
        JsonContent = jsonReader.ReadToEnd();
    }

    /// <summary>
    /// Renvoie une List<> des données JSON de l'objet/array demandé
    /// </summary>
    /// <typeparam name="T">Classe des objets JSON</typeparam>
    /// <param name="valueToSearch"></param>
    /// <returns>List<typeparamref name="T"/></returns>
    public List<T> SearchDataFromJsonRessources<T>(string valueToSearch)
    {
        // Récupère les données JSON dans un objet JSON
        JObject jObject = JObject.Parse(JsonContent);

        // Récupère l'objet demandé
        return JsonConvert.DeserializeObject<List<T>>(jObject[valueToSearch].ToString());
    }
}
