using System.Collections;
using TMPro;
using UnityEngine;

public class AnimationFade : MonoBehaviour, IServiceLocator
{
    [SerializeField] private TMP_Text _hintText;
    [Range(0,5f)]
    [SerializeField] private float _speedAnimation;
    [SerializeField] private bool _oneShotPlayAnimation;

    private int _delay = 2;

    private void Update()
    {
        if (_oneShotPlayAnimation)
        {  
            _hintText.color = new Color(_hintText.color.r, _hintText.color.g, _hintText.color.b, Mathf.PingPong(Time.time / _speedAnimation, 1.0f));
            StartCoroutine("DestroyObject");
        }
        else
        {
            _hintText.color = new Color(_hintText.color.r, _hintText.color.g, _hintText.color.b, Mathf.PingPong(Time.time / _speedAnimation, 1.0f));
        } 
    }

    public void Close()
    {
        _hintText.color = new Color(_hintText.color.r, _hintText.color.g, _hintText.color.b, 0f);
        gameObject.SetActive(false);
    }


    IEnumerator DestroyObject()
    {
       
        yield return new WaitForSeconds( _speedAnimation * _delay);
        Destroy(gameObject);
    }
}
