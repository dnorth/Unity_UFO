using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour 
{
	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody2D rb2d;
	private int count;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D> ();
		count = 0;
		countText.text = GetCountText (count);
		winText.text = "";
	}
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		rb2d.AddForce (movement * speed);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("PickUp")) 
		{
			other.gameObject.SetActive (false);
			count += 1;
			countText.text = GetCountText (count);

			if (count == 8)
			{
				winText.text = "You win!";
			}
		}
	}

	string GetCountText(int count)
	{
		return "Count: " + count.ToString ();
	}
}
