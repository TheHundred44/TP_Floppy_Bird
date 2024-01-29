using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip m_hit;
    [SerializeField]
    private AudioClip m_score;
    [SerializeField]
    private AudioClip m_wing;

    private AudioSource m_source;

    [SerializeField]
    private DeadZone m_deadZone;
    [SerializeField]
    private ZoneScore m_zoneScore;
    [SerializeField]
    private FloppyJump m_floppyJump;

    private void Start()
    {
        m_source = GetComponent<AudioSource>();

        m_deadZone.OnDeadSong += PlayHitSong;
        m_zoneScore.OnScoreSong += PlayScoreSong;
        m_floppyJump.OnJumpSong += PlayWingSong;
    }

    public void PlayHitSong()
    {
        m_source.clip = m_hit;
        m_source.Play();
    }

    public void PlayScoreSong()
    {
        m_source.clip = m_score;
        m_source.Play();
    }

    public void PlayWingSong()
    {
        m_source.clip = m_wing;
        m_source.Play();
    }
}
