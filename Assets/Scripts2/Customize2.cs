using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using System.IO;
using System.Collections.Generic;
using SimpleJSON;
using Newtonsoft.Json.Linq;

public class Customize2 : MonoBehaviour
{
    [Header("Mesh to Change")]
    public MeshFilter hairstyle;
    public MeshFilter hairstyle2;
    public MeshFilter hairstyle3;

    [Header("Hair Mesh to cycle Throught")]
    public List<Mesh> meshes = new List<Mesh>();

    [Header("Mesh to Change")]
    public MeshRenderer hairColor;
    public MeshRenderer hairColor2;
    public MeshRenderer hairColor3;

    [Header("hair Colors to cycle Throught")]
    public List<Material> materials = new List<Material>();

    [Header("Mesh to Change")]
    public MeshRenderer SkinColor;
    public MeshRenderer SkinColor2;

    public MeshRenderer SkinColor3;

    [Header("SkinColors to Scycle Throught")]
    public List<Material> materials2 = new List<Material>();




    [Header("Clothes to change")]
    public MeshFilter clothes;
    public MeshRenderer clothesmat;
    public MeshFilter clothes2;
    public MeshRenderer clothesmat2;
    public MeshFilter clothes3;
    public MeshRenderer clothesmat3;

    [Header("Clothes to cycle throught")]
    public List<Mesh> clothesmeshes = new List<Mesh>();
    public List<Material> clothesmaterials = new List<Material>();

    [Header("Facials to change")]

    public MeshFilter facial1;
    public MeshRenderer facialmat1;
    public MeshFilter facial2;
    public MeshRenderer facialmat2;
    public MeshFilter facial3;
    public MeshRenderer facialmat3;


    [Header("Facials to cycle throught")]
    public List<Mesh> facialmeshs = new List<Mesh>();
    public List<Material> facialmats = new List<Material>();


    [Header("Accessorie to change")]
    public MeshFilter acc1;
    public MeshRenderer accmat1;
    public MeshFilter acc2;
    public MeshRenderer accmat2;
    public MeshFilter acc3;
    public MeshRenderer accmat3;


    [Header("Accessorie to cycle throught")]
    public List<Mesh> accmeshs = new List<Mesh>();
    public List<Material> accmats = new List<Material>();


    public GameObject beard1;
    public GameObject beard2;
    public GameObject beard3;
    public GameObject beard4;
    public GameObject beard5;
    public GameObject eyeLashes;
    public GameObject CameraAcc;
    public GameObject necklace;

    int currentoption = 0;
    string jsonfile;
    Characteristics charactersInJson;
    int i = 0;
    string url = "https://virtuelodc-backend.herokuapp.com/onecharacter/61b31b5ae5e82cd2a841a109";
    string str;

    IEnumerator Start()
    {

        WWW www = new WWW(url);
        yield return www;
        if (www.error == null)
        {

            get(www);

        }
        else
        {
            Debug.Log("ERROR: " + www.error);
        }
    }
    void get(WWW www)
    {
        JObject jsonfile = JObject.Parse(www.text);
        str = jsonfile.ToString();

        string sexe = (string)jsonfile["characters"]["sexe"];
        string peau = (string)jsonfile["characters"]["peau"];
        string cheveux = (string)jsonfile["characters"]["cheveux"];
        string accessoire = (string)jsonfile["characters"]["accessoire"];
        string vetement = (string)jsonfile["characters"]["vetement"];

        print("affiche1 " + jsonfile["characters"]["cheveux"]);
        print("affiche2 " + (jsonfile["characters"]["cheveux"]).Equals("CF4"));
        print("affiche3 " + jsonfile["characters"]["cheveux"]);

        if (string.Equals(sexe, "H"))
        {
            eyeLashes.SetActive(false);
        }
        switch (cheveux)
        {
            case "CF0":
                hairstyle2.mesh = meshes[5];
                hairColor2.material = materials[1];
                break;
            case "CF1":
                hairstyle2.mesh = meshes[6];
                hairColor2.material = materials[2];
                break;
            case "CF2":
                hairstyle2.mesh = meshes[12];
                hairColor2.material = materials[3];
                break;
            case "CF3":
                hairstyle2.mesh = meshes[9];
                hairColor2.material = materials[2];
                break;
            case "CF4":
                hairstyle2.mesh = meshes[10];
                hairColor2.material = materials[2];
                break;
            case "CF5":
                hairstyle2.mesh = meshes[3];
                hairColor2.material = materials[2];
                break;
            case "CF6":
                hairstyle2.mesh = meshes[8];
                hairColor2.material = materials[1];
                break;
            case "CF7":
                hairstyle2.mesh = meshes[2];
                hairColor2.material = materials[1];
                break;
            case "CF8":
                hairstyle2.mesh = meshes[0];
                hairColor2.material = materials[3];
                break;
            case "CF9":
                hairstyle2.mesh = meshes[2];
                hairColor2.material = materials[0];
                break;
            case "CH0":
                beard1.SetActive(true);
                hairstyle2.mesh = meshes[15];
                break;
            case "CH1":
                beard2.SetActive(true);
                hairstyle2.mesh = meshes[15];
                break;
            case "CH2":
                beard3.SetActive(true);
                hairstyle2.mesh = meshes[15];

                break;
            case "CH3":
                beard4.SetActive(true);
                hairstyle2.mesh = meshes[15];

                break;
            case "CH4":
                beard5.SetActive(true);
                hairstyle2.mesh = meshes[15];

                break;
            case "CH5":

                hairstyle2.mesh = meshes[15];
                break;
            default:

                break;
        }
        switch (peau)
        {
            case "0":
                SkinColor2.material = materials2[0];
                break;
            case "1":
                SkinColor2.material = materials2[1];
                break;
            case "2":
                SkinColor2.material = materials2[2];
                break;
            case "3":
                SkinColor2.material = materials2[3];
                break;
            case "4":
                SkinColor2.material = materials2[4];
                break;
            case "5":
                SkinColor2.material = materials2[5];
                break;
            case "6":
                SkinColor2.material = materials2[1];
                break;
            case "HN2":
                SkinColor2.material = materials2[2];
                break;
            case "HM1":
                SkinColor2.material = materials2[0];
                break;
            case "HB1":
                SkinColor2.material = materials2[3];
                break;
            case "HR1":
                SkinColor2.material = materials2[7];
                break;
            case "HJ1":
                SkinColor2.material = materials2[5];
                break;
            default:
                SkinColor2.material = materials2[0];
                break;
        }
        switch (vetement)
        {
            case "0":
                clothesmat2.material = clothesmaterials[2];
                clothes2.mesh = clothesmeshes[2];
                break;
            case "1":
                clothesmat2.material = clothesmaterials[5];
                clothes2.mesh = clothesmeshes[5];
                break;
            case "2":
                clothesmat2.material = clothesmaterials[7];
                clothes2.mesh = clothesmeshes[7];
                break;
            case "3":
                clothesmat2.material = clothesmaterials[4];
                clothes2.mesh = clothesmeshes[4];
                break;
            case "4":
                clothesmat2.material = clothesmaterials[1];
                clothes2.mesh = clothesmeshes[1];
                break;
            case "V0":
                clothesmat2.material = clothesmaterials[3];
                clothes2.mesh = clothesmeshes[3];
                break;
            case "V1":
                clothesmat2.material = clothesmaterials[5];
                clothes2.mesh = clothesmeshes[5];
                break;
            case "V2":
                clothesmat2.material = clothesmaterials[0];
                clothes2.mesh = clothesmeshes[0];
                break;
            case "V3":
                clothesmat2.material = clothesmaterials[6];
                clothes2.mesh = clothesmeshes[6];
                break;
            case "V4":
                clothesmat2.material = clothesmaterials[4];
                clothes2.mesh = clothesmeshes[4];
                break;
            default:
                clothesmat2.material = clothesmaterials[0];
                clothes2.mesh = clothesmeshes[0];
                break;
        }
        switch (accessoire)
        {
            case "0":
                acc2.mesh = accmeshs[0];
                accmat2.material = accmats[1];
               
                break;
            case "1":
                acc2.mesh = accmeshs[1];
                accmat2.material = accmats[0];
               
                break;
            case "2":
                acc2.mesh = accmeshs[3];
                accmat2.material = accmats[2]; 
                break;
            case "3":
                acc2.mesh = accmeshs[3];
                accmat2.material = accmats[2]; 
                break;
            case "4":
                CameraAcc.SetActive(true);
                break;
            case "5":
                acc2.mesh = accmeshs[5];
                accmat2.material = accmats[2];
                break;
            case "6":
                CameraAcc.SetActive(true);
                break;
            case "7":
                necklace.SetActive(true);
                break;
            case "ACC9":
                acc2.mesh = accmeshs[8];
                accmat2.material = accmats[8]; hairstyle2.mesh = meshes[4];
                break;
            case "ACC10":
                acc2.mesh = accmeshs[9];
                accmat2.material = accmats[8]; hairstyle2.mesh = meshes[4];
                break;
            case "ACC11":
                acc2.mesh = accmeshs[7];
                accmat2.material = accmats[7]; hairstyle2.mesh = meshes[4];
                break;
            case "ACC12":
                acc2.mesh = accmeshs[0];
                accmat2.material = accmats[0]; hairstyle2.mesh = meshes[4];
                break;
            default:
                acc2.mesh = accmeshs[8];
                accmat2.material = accmats[8];
                break;

        }





        //charactersInJson = JsonUtility.FromJson<Character1>(str);
        //StartCoroutine(changechars(charactersInJson));
        //character c = APIhelper.GetCharacter();
        //print("c.nom" + c.message);
        //Debug.Log(i);
        Debug.Log("louay khemiri " + str);

    }
}
