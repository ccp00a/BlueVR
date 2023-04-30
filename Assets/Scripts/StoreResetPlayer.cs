using UnityEngine;

public class StoreResetPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform resetTransform;
    [SerializeField] GameObject player;
    [SerializeField] Camera playerHead;

    public void ResetPlayer()
    {
        var rotationAngleY = resetTransform.rotation.eulerAngles.y - playerHead.transform.eulerAngles.y;
        player.transform.Rotate(0, rotationAngleY, 0);

        var distanceDiff = resetTransform.position - playerHead.transform.position;
        player.transform.position += new Vector3(distanceDiff.x, 0, distanceDiff.z);
    }
}
