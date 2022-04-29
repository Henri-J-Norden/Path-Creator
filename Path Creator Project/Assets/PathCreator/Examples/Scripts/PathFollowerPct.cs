using UnityEngine;

namespace PathCreation.Examples
{
    // Moves along a path at constant speed.
    // Depending on the end of path instruction, will either loop, reverse, or stop at the end of the path.
    public class PathFollowerPct : MonoBehaviour
    {
        public PathCreator pathCreator;
        public EndOfPathInstruction endOfPathInstruction;
        public float speed = 1;
        public float pct = 0;


        void Start() { }

        void Update()
        {
            if (pathCreator != null)
            {
	             pct += speed * Time.deltaTime;
	             transform.position = pathCreator.path.GetPointAtTime(pct, endOfPathInstruction);
	             transform.rotation = pathCreator.path.GetRotation(pct, endOfPathInstruction);
            }
        }
    }
}