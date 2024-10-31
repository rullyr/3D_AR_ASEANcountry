using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject HomeMenu;
    public GameObject InfoMenu;
    public GameObject MenuSejarah;
    public GameObject DaftarNegara;
    public GameObject Brunei;
    public GameObject Filipina;
    public GameObject Indonesia;
    public GameObject Kamboja;
    public GameObject Laos;
    public GameObject Malaysia;
    public GameObject Myanmar;
    public GameObject Singapura;
    public GameObject Thailand;
    public GameObject Vietnam;

    void Start() {
        HomeMenu.SetActive(true);
        InfoMenu.SetActive(false);
        MenuSejarah.SetActive(false);
        DaftarNegara.SetActive(false);
        Brunei.SetActive(false);
        Filipina.SetActive(false);
        Indonesia.SetActive(false);
        Kamboja.SetActive(false);
        Laos.SetActive(false);
        Malaysia.SetActive(false);
        Myanmar.SetActive(false);
        Singapura.SetActive(false);
        Thailand.SetActive(false);
        Vietnam.SetActive(false);
    }
    
    public void InfoClicked() {
        HomeMenu.SetActive(false);
        InfoMenu.SetActive(true);
        MenuSejarah.SetActive(false);
        DaftarNegara.SetActive(false);
        Brunei.SetActive(false);
        Filipina.SetActive(false);
        Indonesia.SetActive(false);
        Kamboja.SetActive(false);
        Laos.SetActive(false);
        Malaysia.SetActive(false);
        Myanmar.SetActive(false);
        Singapura.SetActive(false);
        Thailand.SetActive(false);
        Vietnam.SetActive(false);
    }

    public void SejarahClicked() {
        HomeMenu.SetActive(false);
        InfoMenu.SetActive(false);
        MenuSejarah.SetActive(true);
        DaftarNegara.SetActive(false);
        Brunei.SetActive(false);
        Filipina.SetActive(false);
        Indonesia.SetActive(false);
        Kamboja.SetActive(false);
        Laos.SetActive(false);
        Malaysia.SetActive(false);
        Myanmar.SetActive(false);
        Singapura.SetActive(false);
        Thailand.SetActive(false);
        Vietnam.SetActive(false);
    }
    public void NegaraClicked() {
        HomeMenu.SetActive(false);
        InfoMenu.SetActive(false);
        MenuSejarah.SetActive(false);
        DaftarNegara.SetActive(true);
        Brunei.SetActive(false);
        Filipina.SetActive(false);
        Indonesia.SetActive(false);
        Kamboja.SetActive(false);
        Laos.SetActive(false);
        Malaysia.SetActive(false);
        Myanmar.SetActive(false);
        Singapura.SetActive(false);
        Thailand.SetActive(false);
        Vietnam.SetActive(false);
    }
    public void BruClicked() {
        HomeMenu.SetActive(false);
        InfoMenu.SetActive(false);
        MenuSejarah.SetActive(false);
        DaftarNegara.SetActive(false);
        Brunei.SetActive(true);
        Filipina.SetActive(false);
        Indonesia.SetActive(false);
        Kamboja.SetActive(false);
        Laos.SetActive(false);
        Malaysia.SetActive(false);
        Myanmar.SetActive(false);
        Singapura.SetActive(false);
        Thailand.SetActive(false);
        Vietnam.SetActive(false);
    }

    public void FilClicked() {
        HomeMenu.SetActive(false);
        InfoMenu.SetActive(false);
        MenuSejarah.SetActive(false);
        DaftarNegara.SetActive(false);
        Brunei.SetActive(false);
        Filipina.SetActive(true);
        Indonesia.SetActive(false);
        Kamboja.SetActive(false);
        Laos.SetActive(false);
        Malaysia.SetActive(false);
        Myanmar.SetActive(false);
        Singapura.SetActive(false);
        Thailand.SetActive(false);
        Vietnam.SetActive(false);
    }

    public void IdnClicked() {
        HomeMenu.SetActive(false);
        InfoMenu.SetActive(false);
        MenuSejarah.SetActive(false);
        DaftarNegara.SetActive(false);
        Brunei.SetActive(false);
        Filipina.SetActive(false);
        Indonesia.SetActive(true);
        Kamboja.SetActive(false);
        Laos.SetActive(false);
        Malaysia.SetActive(false);
        Myanmar.SetActive(false);
        Singapura.SetActive(false);
        Thailand.SetActive(false);
        Vietnam.SetActive(false);
    }

    public void KamClicked() {
        HomeMenu.SetActive(false);
        InfoMenu.SetActive(false);
        MenuSejarah.SetActive(false);
        DaftarNegara.SetActive(false);
        Brunei.SetActive(false);
        Filipina.SetActive(false);
        Indonesia.SetActive(false);
        Kamboja.SetActive(true);
        Laos.SetActive(false);
        Malaysia.SetActive(false);
        Myanmar.SetActive(false);
        Singapura.SetActive(false);
        Thailand.SetActive(false);
        Vietnam.SetActive(false);
    }

    public void LaosClicked() {
        HomeMenu.SetActive(false);
        InfoMenu.SetActive(false);
        MenuSejarah.SetActive(false);
        DaftarNegara.SetActive(false);
        Brunei.SetActive(false);
        Filipina.SetActive(false);
        Indonesia.SetActive(false);
        Kamboja.SetActive(false);
        Laos.SetActive(true);
        Malaysia.SetActive(false);
        Myanmar.SetActive(false);
        Singapura.SetActive(false);
        Thailand.SetActive(false);
        Vietnam.SetActive(false);
    }

    public void MasClicked() {
        HomeMenu.SetActive(false);
        InfoMenu.SetActive(false);
        MenuSejarah.SetActive(false);
        DaftarNegara.SetActive(false);
        Brunei.SetActive(false);
        Filipina.SetActive(false);
        Indonesia.SetActive(false);
        Kamboja.SetActive(false);
        Laos.SetActive(false);
        Malaysia.SetActive(true);
        Myanmar.SetActive(false);
        Singapura.SetActive(false);
        Thailand.SetActive(false);
        Vietnam.SetActive(false);
    }

    public void MyaClicked() {
        HomeMenu.SetActive(false);
        InfoMenu.SetActive(false);
        MenuSejarah.SetActive(false);
        DaftarNegara.SetActive(false);
        Brunei.SetActive(false);
        Filipina.SetActive(false);
        Indonesia.SetActive(false);
        Kamboja.SetActive(false);
        Laos.SetActive(false);
        Malaysia.SetActive(false);
        Myanmar.SetActive(true);
        Singapura.SetActive(false);
        Thailand.SetActive(false);
        Vietnam.SetActive(false);
    }

    public void SigClicked() {
        HomeMenu.SetActive(false);
        InfoMenu.SetActive(false);
        MenuSejarah.SetActive(false);
        DaftarNegara.SetActive(false);
        Brunei.SetActive(false);
        Filipina.SetActive(false);
        Indonesia.SetActive(false);
        Kamboja.SetActive(false);
        Laos.SetActive(false);
        Malaysia.SetActive(false);
        Myanmar.SetActive(false);
        Singapura.SetActive(true);
        Thailand.SetActive(false);
        Vietnam.SetActive(false);
    }

    public void ThaiClicked() {
        HomeMenu.SetActive(false);
        InfoMenu.SetActive(false);
        MenuSejarah.SetActive(false);
        DaftarNegara.SetActive(false);
        Brunei.SetActive(false);
        Filipina.SetActive(false);
        Indonesia.SetActive(false);
        Kamboja.SetActive(false);
        Laos.SetActive(false);
        Malaysia.SetActive(false);
        Myanmar.SetActive(false);
        Singapura.SetActive(false);
        Thailand.SetActive(true);
        Vietnam.SetActive(false);
    }

    public void VietClicked() {
        HomeMenu.SetActive(false);
        InfoMenu.SetActive(false);
        MenuSejarah.SetActive(false);
        DaftarNegara.SetActive(false);
        Brunei.SetActive(false);
        Filipina.SetActive(false);
        Indonesia.SetActive(false);
        Kamboja.SetActive(false);
        Laos.SetActive(false);
        Malaysia.SetActive(false);
        Myanmar.SetActive(false);
        Singapura.SetActive(false);
        Thailand.SetActive(false);
        Vietnam.SetActive(true);
    }

    public void KembaliClicked(){
        HomeMenu.SetActive(true);
        InfoMenu.SetActive(false);
        MenuSejarah.SetActive(false);
        DaftarNegara.SetActive(false);
        Brunei.SetActive(false);
        Filipina.SetActive(false);
        Indonesia.SetActive(false);
        Kamboja.SetActive(false);
        Laos.SetActive(false);
        Malaysia.SetActive(false);
        Myanmar.SetActive(false);
        Singapura.SetActive(false);
        Thailand.SetActive(false);
        Vietnam.SetActive(false);
    }

    public void Kembali2Clicked(){
        HomeMenu.SetActive(false);
        InfoMenu.SetActive(false);
        MenuSejarah.SetActive(true);
        DaftarNegara.SetActive(false);
        Brunei.SetActive(false);
        Filipina.SetActive(false);
        Indonesia.SetActive(false);
        Kamboja.SetActive(false);
        Laos.SetActive(false);
        Malaysia.SetActive(false);
        Myanmar.SetActive(false);
        Singapura.SetActive(false);
        Thailand.SetActive(false);
        Vietnam.SetActive(false);
    }

    public void Kembali3Clicked(){
        HomeMenu.SetActive(false);
        InfoMenu.SetActive(false);
        MenuSejarah.SetActive(false);
        DaftarNegara.SetActive(true);
        Brunei.SetActive(false);
        Filipina.SetActive(false);
        Indonesia.SetActive(false);
        Kamboja.SetActive(false);
        Laos.SetActive(false);
        Malaysia.SetActive(false);
        Myanmar.SetActive(false);
        Singapura.SetActive(false);
        Thailand.SetActive(false);
        Vietnam.SetActive(false);
    }

    public void LoadScene(string scenename){
        SceneManager.LoadScene (scenename);
    }
}