PGDMP  &    (                }            basvuru    17.5    17.5     6           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false            7           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            8           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            9           1262    16400    basvuru    DATABASE     �   CREATE DATABASE basvuru WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1252';
    DROP DATABASE basvuru;
                     postgres    false            �            1259    16416    ilceler    TABLE     v   CREATE TABLE public.ilceler (
    ilid bigint NOT NULL,
    ilceid bigint NOT NULL,
    adi character varying(100)
);
    DROP TABLE public.ilceler;
       public         heap r       postgres    false            �            1259    16411    iller    TABLE     V   CREATE TABLE public.iller (
    id bigint NOT NULL,
    adi character varying(100)
);
    DROP TABLE public.iller;
       public         heap r       postgres    false            �            1259    16408    personelisbasvurulari    TABLE     ,  CREATE TABLE public.personelisbasvurulari (
    personelid bigint,
    basvurutarihi timestamp without time zone,
    ilid bigint,
    seyahatengeliyok boolean,
    isyeriadi character varying(100),
    pozisyon character varying(100),
    aciklama character varying(100),
    id integer NOT NULL
);
 )   DROP TABLE public.personelisbasvurulari;
       public         heap r       postgres    false            �            1259    24623    personelisbasvurulari_id_seq    SEQUENCE     �   CREATE SEQUENCE public.personelisbasvurulari_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 3   DROP SEQUENCE public.personelisbasvurulari_id_seq;
       public               postgres    false    219            :           0    0    personelisbasvurulari_id_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE public.personelisbasvurulari_id_seq OWNED BY public.personelisbasvurulari.id;
          public               postgres    false    222            �            1259    16402    personeller    TABLE     �   CREATE TABLE public.personeller (
    id bigint NOT NULL,
    adisoyadi character varying(50),
    ilid bigint,
    ilceid bigint,
    cinsiyet character varying(50),
    dogumtarihi timestamp without time zone,
    aciklama character varying(100)
);
    DROP TABLE public.personeller;
       public         heap r       postgres    false            �            1259    16401    personeller_id_seq    SEQUENCE     {   CREATE SEQUENCE public.personeller_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.personeller_id_seq;
       public               postgres    false    218            ;           0    0    personeller_id_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.personeller_id_seq OWNED BY public.personeller.id;
          public               postgres    false    217            �           2604    24624    personelisbasvurulari id    DEFAULT     �   ALTER TABLE ONLY public.personelisbasvurulari ALTER COLUMN id SET DEFAULT nextval('public.personelisbasvurulari_id_seq'::regclass);
 G   ALTER TABLE public.personelisbasvurulari ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    222    219            �           2604    16405    personeller id    DEFAULT     p   ALTER TABLE ONLY public.personeller ALTER COLUMN id SET DEFAULT nextval('public.personeller_id_seq'::regclass);
 =   ALTER TABLE public.personeller ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    217    218    218            2          0    16416    ilceler 
   TABLE DATA           4   COPY public.ilceler (ilid, ilceid, adi) FROM stdin;
    public               postgres    false    221   �       1          0    16411    iller 
   TABLE DATA           (   COPY public.iller (id, adi) FROM stdin;
    public               postgres    false    220   I6       0          0    16408    personelisbasvurulari 
   TABLE DATA           �   COPY public.personelisbasvurulari (personelid, basvurutarihi, ilid, seyahatengeliyok, isyeriadi, pozisyon, aciklama, id) FROM stdin;
    public               postgres    false    219   �8       /          0    16402    personeller 
   TABLE DATA           c   COPY public.personeller (id, adisoyadi, ilid, ilceid, cinsiyet, dogumtarihi, aciklama) FROM stdin;
    public               postgres    false    218   �9       <           0    0    personelisbasvurulari_id_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public.personelisbasvurulari_id_seq', 6, true);
          public               postgres    false    222            =           0    0    personeller_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.personeller_id_seq', 8, true);
          public               postgres    false    217            �           2606    16420    ilceler ilceler_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.ilceler
    ADD CONSTRAINT ilceler_pkey PRIMARY KEY (ilid, ilceid);
 >   ALTER TABLE ONLY public.ilceler DROP CONSTRAINT ilceler_pkey;
       public                 postgres    false    221    221            �           2606    16415    iller iller_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.iller
    ADD CONSTRAINT iller_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.iller DROP CONSTRAINT iller_pkey;
       public                 postgres    false    220            �           2606    24626 0   personelisbasvurulari personelisbasvurulari_pkey 
   CONSTRAINT     n   ALTER TABLE ONLY public.personelisbasvurulari
    ADD CONSTRAINT personelisbasvurulari_pkey PRIMARY KEY (id);
 Z   ALTER TABLE ONLY public.personelisbasvurulari DROP CONSTRAINT personelisbasvurulari_pkey;
       public                 postgres    false    219            �           2606    16407    personeller personeller_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.personeller
    ADD CONSTRAINT personeller_pkey PRIMARY KEY (id);
 F   ALTER TABLE ONLY public.personeller DROP CONSTRAINT personeller_pkey;
       public                 postgres    false    218            2      x�][���F��Q_1f��Q�f��4�дZ1j)B�u�$XD�A� `�`,Ŷ��#�<V�מsn�];NE� ���άU�
�u/�nt�������*���y�:4���?S=������˺D#	^�ݺ��� � ߻jp���Lpt_?������*������>��U�����pؿ|�|v-a��a��뮯���S;�#�&��_����S�߄�*�/_f��s�,xS]�f�ٔMU��I���J~���լ1fx�9�G�&�����lG�/U��j�c�k���0	v�1�=�'�o�W���gt�p���y��Мܶ�
��hE�h֮k�E�
޺s��WQ��:{�m�s���񴩚R����a�|)�i�}��06�2�[������՗KT`��n��񽦋�|�E�uGL���6ljF��Q��a���=�$�(xx�ā�c�f�o!56���n<6��Ou�f�;��e3~vcw�.����F"2�H����I�rܺavl��ȹ�<oJ=�������O{����t�_q����8	ޗ���:����(� �~� �<x�g��Ҭ% N�B��
����4���Gw�tS�\�yl˾$����z=�­��m.L�޳�q��rx���i�]管Y���4�(����sC��Dg�{�BHuSR~" j&�q�cy�\� '�dlܞ�D.ޣ�/��'�`
{��th��دC�'��2��"Bl� !��*x�|69��]�⧚��ɂ�Se]��=���ZuX&����寯�ʶt�R�V�1��W]U�7,�;W�\�B��m!�����^�{��}���n��[�۷eۗ"�f����Ρ��*��MX�����)<��4��B㦶�6H����	F!�=��O���8W�а��V�h�����.��@�ޝ*�P?��^	lK�\;���h͌�?M�-d��m��cK�	?9
��ô�peJ4D 2}8sݜaH��w=�ք�l���RΫ�T�`[���f���������)1�@�TT62�I6@��sc������s`��)����S��4c��q>W������kn��ēL*���`IV���ɻ��T�� Q%�]#�ڷ��JVO���Ma�$�SvZD��M�yF��o���F�I��oK�uXyli[.�e��X(���z�Q�>�U���a�!��d�¤��~�B ���1â��N��n���z�K'ŵ����Z�S�Vfo3J��y�<{"��Z��(ѯ=1����)��O��3TÈ�{����<�^��<L���ɣ	BC��	?k�Wv\;��T�CB.RN���(,a�q��fP4�"V��ma���`��U�)�O�lwSi �HƦ%�K�a���9P}GXD�i<�QT0��Ԇ�]��m�<���������;ֆ#�o��6�fr1\a�T������w�����,�RCan��+�����^\�̅�}[�m����i�����1�%�(Y�#�mc�`�2&��x1!��R�
U�I���/we���s�맪�>� ��&��^����l�.�J�ý%
�VP��V�LD�-M��c�s�|�xC&�&��5�` bW��r��� ��4�n������p?U��y�9���4�84�;gDd�􍈵p�����P^���x*����+��R�z��eͬMY<o̮��^���Wj���K5&7�[S֞�2�Ø�Z�ML��P��[d��|gO���pAЄr�nr �Xk���*�,�!�0}�-��-�ۘ�c���*�(��y�R�K�$_���?M�}l���4u�����Bm�`�����v��[�y�=��+�K�y�'�mY�P]����=@����L݆�j��a�nO��dXK(Yg��=�q�)����XK��NKx�G�%���k�I�		�{�w0��/@E�؃.��1���|��bR�v�^�("��A!t�oZ&�)	x�f��]�&������������D:��� #�
NԿ�H�v^^�]�6`��w�b"P(�T;e�ۻ�:�Ԃ=��Ą0�'8c�b���Ѱ��9��C J$�-�R�&wy7Đ���#�p$E����z��x��0Y&b갴i���� �������6bH�����:��!h�EB9$�wP�6Eж��q[�0B��C��6�r�����dK�a�WF�B	Ĺqf3E�L�h��0dI���l�ug�����aJ��2o/��^%���@
�A�&�t�4C0nS^�.q,��<����F��D�$�Ѧ�B�X�?gjERQ	�kѽ��[D�!���VY�p�5k�
�?(��36��t{Jo\ÈT8	>����
i��r����a��/���O����% �t��%��L,��kwg�\�hm�2�����Ի�?@H�:)+D�^/��幕�Td0"cr��4!%�#�����f�Ԇ�}h&�;d�	�e�`�B<~vCձ�"����JD�D�rz��S/�g��Џ��B��LA�0b��Q�3�:Nj3�`�f�"�V��RC!�� ���Q���E���G��ܾ���o�����+B�A)�!��S�D��
+�-� ���r��k_�QL��#�lb)�e`��:m"�6��BFB�\���m�A�{Y��������ܕ������WʫH�'`��BYSR����#�GƎ4H(�׀^Rɉ��3��9*����诽e�9��ɃG2gHs<w�#A���W}�pZ�A(\nc/����Y���8����g�	繮^�(ECѽ�,a�Nt3�8ы��U���\��F2J�)��|Ə�GȠa+�B%jn �Q��2�����y�`�!�[��'2�yY��C�#f�.,@m������Vg`e���phf� �d�g<l�a��U���x,&�b���kNI�[yԈ�g��^=k[j�y�J�Bz徂��{�Ѹ�'�b��0�F�K�/�?G��R0������K|��6F�t���3=ao�Ԥ�+J������,�6ӵ����o�<�w=�4�N7kȬ�m#D�ש�+��
�����a�n�l)�*�4.W���,�>7F�vˆ&wzO�<3�6�bm͐�H��K��M��n0SR�
������4�1�ډ2�vc�{��ý��y��8�WP��a`�G��T�I�A�qS�k�a��W��.ǲvD%~d�����ԇ���{��yq�g;��&�Uݖ06�uT�F�l����:F��Pv�$xd�ʹp;wy>H���X��*��;|�Kdq��?� �b���E0��n�2T�Xߢ.4�d�(��2�t5�k	C�M�<����<1_7���Q�N�[����y���S�b�aUc�	A���p@�a@^�g��#HN������<��<§�H���V�+e�65�N+���;cr;�!��	�@k_��;̔��wK<�`I[�(�nj/_n�˂�Ý=���@��A%R/�6!�dż�P|���@.�(�ʆ��gx赔E\��F�`Y���Q�l8	��{3��,��e1��;�#B�}:R*�;�$c��lK߹���u�)�˿`����l<
)w��bڇ���Kx$�ck�W�ݲ%�I����m��6"X���t.&��z:�r�g��b�'��vqo���T�4��5����g ��k�$	�*�qtD	7:�E�:̮��`|WmKkގ�%��x������ԗ5Q��f�_r� WQ��R"�Ϻ�Ǳ?5�#��T��G���0"��<�)�) Ӓ?�a�������\�W
#-"6b�3�%y��=���+Y�'�\��1�l7s�N�A�P|_�0X�G��� �upR2� ,��<�����
���������n-�3>�����LD���b�Ά����۴�?۴B��ل�x)�z(@*�Ȕ��Z�R�ͮ�X)��y�������F�?��Y����r߰`������ۏC����E�Mz��8EF"x���*n���= M  ��D��P�B��{i1�W ��x�@�@L��b`-�2�1�@&��g%�1ck�4���4�;��y�y����\�u�DVAg��l�R��&L��f���!�܍��c�	����W����ӂ\�e	��#�����.�^����!�~q�b��I��u�_k	-�Z�AĒ����u�B�!�,��I��فzW΃�}���fR�%��^Jb�`��Q�`̊1kGB�/��-�����{4�A�d�]�����s_L��^�խ����֫E���Z�)�vLP�M�������,�j~�� !�	�����K1�k�̝;:Å�,*G.�-,����3�Z&N
�c[��f��E� �ؑ�	-�Hc8�JL���zc�NTg?*:�}+i���N	�{ˎ����((���xw����,X<M�h
R���WP�$T`�AS/|�N�[����<x�h�K��r�6\�@a�6n�_����O���x��±���08)|���Ma'�:�~���K#"7���������T����~�DRT�㼣qf���G��!F�M��#�����Y�����o19�Q�A�۶�Y�=Ɩ�T���� �!log�_��a }|��w4��D$�c��F��t*_�r#H]�뀒�D}!��`��V&�&ݼtO��ז����1�aka�G#B9��@�D��&Ņ�u���?<_)����oyyg$i����w9ⅶ������� �eL��0�����I�x�#F�#�z!�'��(���(��RR�/�������j0�c?xX��J�Hj��*�uyB)F��,�L������������c(�Ɲ�t_��湣l��op��,K
7��,�)1��,�a0�2_^O�d��y��51�z��rxq�.T*UN�����Rd���k�E��JO�ۉ��Cߔ��bn����
�p�i$���*�	�̘P�J��b�S�٪�BH�5�jvK���,�S�{�/Nu��19�����]��k\���"��	���/��uu�x�gm�R���Տ[>`�Ξ��-�CH��~2��o���p��gP���^���������?;~�Fa���^�le�Ī�<3�ThS.�wQ�,�7� ��A"�;y�ga�"#�������"��1�Y&Q�O����l��5�����@��N�E�1�RUH;�� ���d���۬Y.�3�6N�<�	�P�u�#I����ٵ�j��t"GVv�,���p~�U�#,Q|��*�#Y{�p}�}���<��#]��]fA���G�֓�`!� ����
��w��H�"0׮�c]�:{��žmyu���_'g�u��m}O<���\w�\�C��Jx"b鵥�$��<+-SJ+.�Q�%L	o�f����K��J5ה�Q��W;a�ʜ�k]�&�WY��}�t���� �^�^�0�<κE"�:�2Boҙ�f�xW2��p
3�r(�ˡ�xf��Bs����&�Jך0���}'���,�.e�h]�ڥ8	*��]=T�C޹]e�f��X�L�PR��CP��<�d[L�388K�֣��md:qq�ժ���3i/	��r�yY��?�a3�^�9��Z�&
�!&Is�Txѓ�����ai��P���XM�8�}2�٠�?�S���x�h�C������;�*7�J	�5��C���/Dpz�n)��

$�?y�&G ����,�x�!�9��=6F�x����)�`=�/9�DZ�rA���@��^j�%�N r������Zna���_/��Dt�����du�q�Hf �q,v֊x����6��]����,>򺴁4��8lbp��z�[�kD6� �����|��E�է��!G���h4�qY�&��/L�6�D|�fW��~\z��@x���ޘ��ᆒ��åZ��L���v��P�"I|�w%,B�q, 4�r�#])�I�"?�(#$�������.$��	����9�]}T��G4ż�$ K�:<����=���ʬ��K#�����-W�Ex/��i�-��Nw
92����|��|��43𸳇�VЉX�*OnA�-KJ&��0�$�X������?�pR4���^��^S��>���{v:��_*|�s��z�F�M������V��vWT�/�я����<U�6�.
�d|�Svv�q�SB�9VZ�,
����W���*��KG�K�k7�fB�,����h�y)	 �g��zSm|�q�x��� R��8�,!E���B���#%`�V(��/�?�����l&�շ�¡?�s{�L9gV�mTN F�k�A�X5�y�K��<n��L�l]CZ��`��<,�M43��kz"��������K�����!��� ����50�9؆����`X�����Ĭ�
�˕風�N��0�(�y��c`}�^��'��B�.�TA���n
+O�e�yg'�Q����^��#����h,��H3���s��f�����-$D���9+C�\�^_�h���@D&'��/�h�z�fu#wڰ ���� P�<�G�U!,t�RFLD�C��\@�r���FD?�'�?���&�H��#��Nl�$,*��,�]����\w�W�ЦoU�"ԡ�������5�����s�D�*؄*,k���	%RN;�ac\�,�]]� � s��)������汱*� r���� @�=�WO#��2:\�~q�4��)�!@85I��Ű��?��:2]�05i� �&<�4��H|V#�4"�ɶ��DX���T��"kD����7:�N�ר�֢2KX�O��(�fi��*���nnn�b'F�      1   u  x�-S=o�0��~I��(J�h#FI��-����fbBP���_Tc�x��M���Q��wz�}�'�9���QI%,_����hj��r�tF˒�0���cƠ!˟rX��d.`�q.�"���\��xV�Z���(b����Ϣ�kj	�*ۢP�j���Gi@5��`�͍Y�"��b:��Ă�ʷ%��hgzk0pc:�;
�0�a}0�i�%�-��y0N`�{��<u�n�4)���\}���n�7���q�����/�x�G��2���?oP
�u(c����7�R½��q���񯶟Q&0���]kQ*����6�k��L��kQ�t����
K^�I4��&6՞f"f�X�D�f�4t8�{���:�P���%�z0ɘ�V3�ᾝ˷��S<��G=%��L�A���5C%��9N��x\I)�eؙJ��ߠ���U��D5�lua��X�4�mUP�����]_9LcضnFK%\��co���ݘ���@�
~��i
�U��g�r��=�-Z��Y�t���v-w�Eaݳ�31��;�,c�R3�3�?�ؤ,h0x���{7R��5�e<��N�s�s��x�g��l�y�c�yM�1g���~���D���-�      0   �   x�U�Kj�0D��)��lτ,g�d�F�D�� �s�l}��^�qLh袠xUg��Z�ZՃ장�'�Jd��\� R������0����Q�=����R��BY!�֔sYE�t!��x�~�P�)�xAk���,������6�+즪y%g��l�'3���,f[�	����r��Z��#��q`��9��yچ�Vv�~���V���h,�b����b�Q4�h67:`����,N��C�4�@n}�      /   �   x�E�K
�0@���*���KҘ�Y���Z(�N���QC�@���fE�NWB�m��vE���6	�1� �b��H)�bl�6�b��&/�����z|�C�9��gQ����d�����mY�]g}U���g� �8i�����ͅ�'�!�Q{+�     