using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class admob : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject personagem;
    public GameObject espinhos;
    public GameObject canvas;

    public static admob instance;
    private BannerView bannerView;
    private InterstitialAd interstitial;

    public int morte;

    private void Awake() {
        if(instance == null)
        {
             instance = this;
              Debug.Log(this);
             DontDestroyOnLoad(this);
            

        }
        else if(instance != this){
            Destroy(gameObject);
            
        }
       
        
    }
    void Start()
    {

        Debug.Log(gameObject);
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3940256099942544/6300978111";
        #elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/2934735716";
        #else
            string adUnitId = "unexpected_platform";
        #endif
         MobileAds.Initialize(initStatus => { });
         RequestBanner();
         RequestInterstitial();

        
    }
     public void RequestBanner()
    {
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3940256099942544/6300978111";
        #elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/2934735716";
        #else
            string adUnitId = "unexpected_platform";
        #endif

        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();
        this.bannerView.LoadAd(request);
        Debug.Log(request);
        //Invoke("DestroyBanner", 10f);
    }
    public void RequestInterstitial()
{
    #if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/1033173712";
    #elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
    #else
        string adUnitId = "unexpected_platform";
    #endif
 
    // Initialize an InterstitialAd.
    this.interstitial = new InterstitialAd(adUnitId);
    AdRequest request = new AdRequest.Builder().Build();
    this.interstitial.LoadAd(request);
    this.interstitial.OnAdClosed += HandleOnAdClosed;
    
}

public void HandleOnAdClosed(object sender, System.EventArgs args){
    SceneManager.LoadScene("gameover");
    AudioListener.pause = false;
    RequestInterstitial();
   

}
public void ShowBanner()
{
  if (this.interstitial.IsLoaded()) {
    this.interstitial.Show();
  }
}

    public void DestroyBanner(){
        bannerView.Destroy();
    }

    // Update is called once per frame
    void Update()
    {
        RequestBanner();
        
    }
   
}
