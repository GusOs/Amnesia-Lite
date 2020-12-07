using UnityEngine;
using System.Collections;




public class Flashlight_PRO : MonoBehaviour 
{
	[Space(10)]
	[SerializeField()] GameObject Lights; // all light effects and spotlight
	[SerializeField()] AudioSource switch_sound; // audio of the switcher
	[SerializeField()] ParticleSystem dust_particles; // dust particles



	private Light spotlight;
	private Material ambient_light_material;
	private Color ambient_mat_color;
	private bool is_enabled = false;

	// Use this for initialization
	void Start () 
	{
		// cache components
		spotlight = Lights.transform.Find ("Spotlight").GetComponent<Light> ();
		ambient_light_material = Lights.transform.Find ("ambient").GetComponent<Renderer> ().material;
		ambient_mat_color = ambient_light_material.GetColor ("_TintColor");
	}

    private void Update()
    {
		Switch();
    }




    /// <summary>
    /// switch current state  ON / OFF.
    /// call this from other scripts.
    /// </summary>
    public void Switch()
	{
		if(Input.GetKey("f"))
        {
			is_enabled = !is_enabled;

			Lights.SetActive(is_enabled);

			if (switch_sound != null)
				switch_sound.Play();
		}
	}





	/// <summary>
	/// enables the particles.
	/// </summary>
	public void Enable_Particles(bool value)
	{
		if(dust_particles != null && is_enabled)
		{
			if(value)
			{
				dust_particles.gameObject.SetActive(true);
				dust_particles.Play();
			}
			else
			{
				dust_particles.Stop();
				dust_particles.gameObject.SetActive(false);
			}
		}
	}


}
