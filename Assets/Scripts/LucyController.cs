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

		while (true)
		{
			// 弾をプレイヤーと同じ位置/角度で作成
			Instantiate (wormEatingHole, transform.position, transform.rotation);
			// 0.05秒待つ
			yield return new WaitForSeconds (eatInterval);
		}
	}
	//操作ボタン
	public void RightButton()
	{	Debug.Log("きてる");
		transform.Translate(1, 0, 0);
	}

	public void Left_Button()
	{
		transform.Translate(-1, 0, 0);
	}

	public void Up_Button()
	{
		transform.Translate(0, 1, 0);
	}

	public void Down_Button()
	{
		transform.Translate(0, -1, 0);
	}

	public void Jump_Button()
	{
		Debug.LogError("呼ばれたよ");
		Animator animator = gameObject.GetComponent<Animator>();
		animator.SetTrigger("Jump");
	}

	//向きの反転

	
	// Update is called once per frame

	// ぶつかった瞬間に呼び出される
	/*void OnTriggerEnter2D (Collider2D c)
	{
		Debug.LogError("あたったよ");
		Animator animator = gameObject.GetComponent<Animator>();
		animator.SetBool("Dead", true);
	}*/
}

