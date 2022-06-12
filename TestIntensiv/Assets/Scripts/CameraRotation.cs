using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
	public Transform target;
	public Vector3 offset;
	public float sensitivity = 3; // ���������������� �����
	public float limit = 80; // ����������� �������� �� Y
	public float zoom = 0.25f; // ���������������� ��� ����������, ��������� �����
	public float zoomMax = 10; // ����. ����������
	public float zoomMin = 3; // ���. ����������
	private float X, Y;
	public static bool cameraRotationBlock = false;

	void Start()
	{
		limit = Mathf.Abs(limit);
		if (limit > 90) limit = 90;
		offset = new Vector3(offset.x, offset.y, -Mathf.Abs(zoomMax) / 2);
		transform.position = target.position + offset;
	}

	void Update()
	{
		if (Input.GetMouseButton(0) && !cameraRotationBlock)
		{
			X = transform.localEulerAngles.y - Input.GetAxis("Mouse X") * sensitivity;
			Y -= Input.GetAxis("Mouse Y") * sensitivity;
			Y = Mathf.Clamp(Y, -limit, limit);
			transform.localEulerAngles = new Vector3(-Y, X, 0);
			transform.position = transform.localRotation * offset + target.position;
		}
	}
}
