using UnityEngine;

public class RandomLighting : MonoBehaviour
{
  public GameObject[] Transitions;

  public float timeToStrike = 10f;
  private float _elapsedTime = 0f;

  private void Update()
  {
    if (_elapsedTime > timeToStrike)
    {
      _elapsedTime = 0;
      GameObject obj = Transitions[Random.Range(0, Transitions.Length)];
      Transition[] transitions = obj.GetComponents<Transition>();
      foreach (Transition transition in transitions)
      {
        transition.Play();
      }
    }
    _elapsedTime += Time.deltaTime;
  }
}
