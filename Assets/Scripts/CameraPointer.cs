//-----------------------------------------------------------------------
// <copyright file="CameraPointer.cs" company="Google LLC">
// Copyright 2020 Google LLC. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections;
using UnityEngine;

/// <summary>
/// Sends messages to gazed GameObject.
/// </summary>
public class CameraPointer : MonoBehaviour
{
    private bool isMove = false;
    private float distance = 0;
    private const float maxDistance = 10;
    private GameObject gazedAtObject = null;
    private TextController textController = null;
    private AudioSource _audioSource = null;
    public AudioClip CoinSound = null;
    public AudioClip HitSound = null;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        textController = GameObject.FindGameObjectWithTag("UIText").GetComponent<TextController>();
    }

    /// <summary>
    /// Update is called once per frame.
    /// </summary>
    public void Update()
    {
        // Dismiss Velocity
        Component.FindObjectOfType<Rigidbody>().velocity = Vector3.zero;

        // Casts ray towards camera's forward direction, to detect if a GameObject is being gazed
        // at.
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance)
            && hit.transform.tag == "Coin")
        {
            // GameObject detected in front ofxxxx the camera.
            if (gazedAtObject != hit.transform.gameObject)
            {
                // New GameObject.
                gazedAtObject?.SendMessage("OnPointerExit");
                gazedAtObject = hit.transform.gameObject;
                gazedAtObject.SendMessage("OnPointerEnter");
                distance = hit.distance;
            }
        }
        else
        {
            // No GameObject detected in front of the camera.
            gazedAtObject?.SendMessage("OnPointerExit");
            gazedAtObject = null;
            distance = 0.0f;
        }
        
        // Checks for screen touches.
        if (Google.XR.Cardboard.Api.IsTriggerPressed || Input.GetMouseButtonDown(0))
        {
            if (gazedAtObject != null)
            {
                _audioSource.PlayOneShot(CoinSound, Mathf.Clamp(1/distance, 0.0f, 0.5f));
                textController.SendMessage("OnPointerClick");
                gazedAtObject.SendMessage("OnPointerClick");
                gazedAtObject = null;
                distance = 0;
            }
            else
            {
                isMove = !isMove;
            }
        }

        if (isMove)
        {
            Vector3 forward = transform.forward;
            forward.y = 0;
            forward.Normalize();
            transform.position += 2.0f * Time.deltaTime * forward;
        }

        if (Input.GetButton("Horizontal"))
        {
            transform.Rotate(90.0f * Time.deltaTime * Input.GetAxis("Horizontal") * Vector3.up);
        }
        if (Input.GetButton("Vertical"))
        {
            transform.Rotate(90.0f * Time.deltaTime * Input.GetAxis("Vertical") * Vector3.right);
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.transform.tag == "Coin")
        {
            _audioSource.PlayOneShot(CoinSound, Mathf.Clamp(1 / distance, 0.0f, 0.5f));
            textController.SendMessage("OnPointerClick");
            Destroy(coll.gameObject);
            gazedAtObject = null;
        }
        else
        {
            _audioSource.PlayOneShot(HitSound, 0.3f);
        }
    }
}
