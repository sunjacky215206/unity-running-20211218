using UnityEngine;      //�ޥ�unity�����Ŷ�,���ڭ̥i�H�ϥθ̭���API(�ܮw)

//���O    ���O�W��(���P�ɮצW�٤@��,�j�p�g�]�O)
public class Car : MonoBehaviour
{
    #region ��� Field
    // �� ���y�k
    // �׹���  �������  ���W��  (���w �w�]��) ����
    // �� �|�j�`�θ������
    // ��  �� int
    // �B�I�� float
    // �r  �� string
    // ���L�� bool
    // �� �׹���
    // �p�H: �����~�����O�s��,�w�],����� private
    // ���}: ���\�~�����O�s��,��� public
    public int cc = 1000;
    public float weight = 3.5f;       // f �� F
    public string brand = "���h";     // "" �]��
    public bool haswindow = true;     // true �� false

    // �� Unity ���`�θ������
    // �C�� Color
    public Color colorA;
    public Color yellow = Color.yellow;
    public Color magenta = Color.magenta;
    public Color colorB = new Color(0.5f, 0, 0.5f);
    public Color colorC = new Color(0, 0.5f, 0.5f, 05f);

    // �V�q Vector 2 ~ 4
    public Vector2 vector2;
    public Vector2 v2Right = Vector2.right;
    public Vector2 v2Up = Vector2.up;
    public Vector2 v2One = Vector2.one;
    public Vector2 vector2A = new Vector2(3.5f, 9.5f);
    #endregion
}

//�D�T�����O���