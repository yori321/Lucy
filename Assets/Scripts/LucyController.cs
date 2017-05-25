using UnityEngine;
using System.Collections;


public class LucyController : MonoBehaviour
{
	// Spaceshipコンポーネント
	Bug bug;

	public float eatInterval = 0.5f;

	// PlayerBulletプレハブ
	public GameObject wormEatingHole;


	// Startメソッドをコルーチンとして呼び出す
	IEnumerator Start ()
	{
		// Spaceshipコンポーネントを取得
		bug = GetComponent<Bug> ();

		while (true) {
			// 弾をプレイヤーと同じ位置/角度で作成
			Instantiate (wormEatingHole, transform.position, transform.rotation);
			// 0.05秒待つ
			yield return new WaitForSeconds (eatInterval);
		}
	}


	
	// Update is called once per frame
	void Update () 
	{
		float x = Input.GetAxisRaw ("Horizontal");

		float y = Input.GetAxisRaw ("Vertical");

		Vector2 direction = new Vector2 (x, y).normalized;

		bug.Move(direction);

	}

	// ぶつかった瞬間に呼び出される
	void OnTriggerEnter2D (Collider2D c)
	{
		Debug.LogError("あたったよ");
		Animator animator = gameObject.GetComponent<Animator>();
		animator.SetBool("Dead", true);
	}
}

