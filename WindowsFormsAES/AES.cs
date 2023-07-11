using System;
using System.Linq;

class AES
{
    private byte[,] sBox = new byte[16, 16]
    {
        // S-Box Lookup Table
            { 0x63, 0x7C, 0x77, 0x7B, 0xF2, 0x6B, 0x6F, 0xC5, 0x30, 0x01, 0x67, 0x2B, 0xFE, 0xD7, 0xAB, 0x76 },
            { 0xCA, 0x82, 0xC9, 0x7D, 0xFA, 0x59, 0x47, 0xF0, 0xAD, 0xD4, 0xA2, 0xAF, 0x9C, 0xA4, 0x72, 0xC0 },
            { 0xB7, 0xFD, 0x93, 0x26, 0x36, 0x3F, 0xF7, 0xCC, 0x34, 0xA5, 0xE5, 0xF1, 0x71, 0xD8, 0x31, 0x15 },
            { 0x04, 0xC7, 0x23, 0xC3, 0x18, 0x96, 0x05, 0x9A, 0x07, 0x12, 0x80, 0xE2, 0xEB, 0x27, 0xB2, 0x75 },
            { 0x09, 0x83, 0x2C, 0x1A, 0x1B, 0x6E, 0x5A, 0xA0, 0x52, 0x3B, 0xD6, 0xB3, 0x29, 0xE3, 0x2F, 0x84 },
            { 0x53, 0xD1, 0x00, 0xED, 0x20, 0xFC, 0xB1, 0x5B, 0x6A, 0xCB, 0xBE, 0x39, 0x4A, 0x4C, 0x58, 0xCF },
            { 0xD0, 0xEF, 0xAA, 0xFB, 0x43, 0x4D, 0x33, 0x85, 0x45, 0xF9, 0x02, 0x7F, 0x50, 0x3C, 0x9F, 0xA8 },
            { 0x51, 0xA3, 0x40, 0x8F, 0x92, 0x9D, 0x38, 0xF5, 0xBC, 0xB6, 0xDA, 0x21, 0x10, 0xFF, 0xF3, 0xD2 },
            { 0xCD, 0x0C, 0x13, 0xEC, 0x5F, 0x97, 0x44, 0x17, 0xC4, 0xA7, 0x7E, 0x3D, 0x64, 0x5D, 0x19, 0x73 },
            { 0x60, 0x81, 0x4F, 0xDC, 0x22, 0x2A, 0x90, 0x88, 0x46, 0xEE, 0xB8, 0x14, 0xDE, 0x5E, 0x0B, 0xDB },
            { 0xE0, 0x32, 0x3A, 0x0A, 0x49, 0x06, 0x24, 0x5C, 0xC2, 0xD3, 0xAC, 0x62, 0x91, 0x95, 0xE4, 0x79 },
            { 0xE7, 0xC8, 0x37, 0x6D, 0x8D, 0xD5, 0x4E, 0xA9, 0x6C, 0x56, 0xF4, 0xEA, 0x65, 0x7A, 0xAE, 0x08 },
            { 0xBA, 0x78, 0x25, 0x2E, 0x1C, 0xA6, 0xB4, 0xC6, 0xE8, 0xDD, 0x74, 0x1F, 0x4B, 0xBD, 0x8B, 0x8A },
            { 0x70, 0x3E, 0xB5, 0x66, 0x48, 0x03, 0xF6, 0x0E, 0x61, 0x35, 0x57, 0xB9, 0x86, 0xC1, 0x1D, 0x9E },
            { 0xE1, 0xF8, 0x98, 0x11, 0x69, 0xD9, 0x8E, 0x94, 0x9B, 0x1E, 0x87, 0xE9, 0xCE, 0x55, 0x28, 0xDF },
            { 0x8C, 0xA1, 0x89, 0x0D, 0xBF, 0xE6, 0x42, 0x68, 0x41, 0x99, 0x2D, 0x0F, 0xB0, 0x54, 0xBB, 0x16 }
    };

    private byte[,] inv_sBox = new byte[16, 16]
    {
            // invS-Box Lookup Table
            { 0x52, 0x09, 0x6A, 0xD5, 0x30, 0x36, 0xA5, 0x38, 0xBf, 0x40, 0xA3, 0x9E, 0x81, 0xF3, 0xD7, 0xFB },
            { 0x7C, 0xE3, 0x39, 0x82, 0x9B, 0x2F, 0xFF, 0x87, 0x34, 0x8E, 0x43, 0x44, 0xC4, 0xDE, 0xE9, 0xCB },
            { 0x54, 0x7B, 0x94, 0x32, 0xA6, 0xC2, 0x23, 0x3D, 0xEE, 0x4C, 0x95, 0x0B, 0x42, 0xFA, 0xC3, 0x4E },
            { 0x08, 0x2E, 0xA1, 0x66, 0x28, 0xD9, 0x24, 0xB2, 0x76, 0x5B, 0xA2, 0x49, 0x6D, 0x8B, 0xD1, 0x25 },
            { 0x72, 0xF8, 0xF6, 0x64, 0x86, 0x68, 0x98, 0x16, 0xD4, 0xA4, 0x5C, 0xCC, 0x5D, 0x65, 0xB6, 0x92 },
            { 0x6C, 0x70, 0x48, 0x50, 0xFD, 0xED, 0xB9, 0xDA, 0x5E, 0x15, 0x46, 0x57, 0xA7, 0x8D, 0x9D, 0x84 },
            { 0x90, 0xD8, 0xAB, 0x00, 0x8C, 0xBC, 0xD3, 0x0A, 0xF7, 0xE4, 0x58, 0x05, 0xB8, 0xB3, 0x45, 0x06 },
            { 0xD0, 0x2C, 0x1E, 0x8F, 0xCA, 0x3F, 0x0F, 0x02, 0xC1, 0xAF, 0xBD, 0x03, 0x01, 0x13, 0x8A, 0x6B },
            { 0x3A, 0x91, 0x11, 0x41, 0x4F, 0x67, 0xDC, 0xEA, 0x97, 0xf2, 0xCF, 0xCE, 0xF0, 0xB4, 0xE6, 0x73 },
            { 0x96, 0xAC, 0x74, 0x22, 0xE7, 0xAD, 0x35, 0x85, 0xE2, 0xF9, 0x37, 0xE8, 0x1C, 0x75, 0xDF, 0x6E },
            { 0x47, 0xF1, 0x1A, 0x71, 0x1D, 0x29, 0xC5, 0x89, 0x6F, 0xB7, 0x62, 0x0E, 0xAA, 0x18, 0xBE, 0x1B },
            { 0xFC, 0x56, 0x3E, 0x4B, 0xC6, 0xD2, 0x79, 0x20, 0x9A, 0xDB, 0xC0, 0xFE, 0x78, 0xCD, 0x5A, 0xF4 },
            { 0x1F, 0xDD, 0xA8, 0x33, 0x88, 0x07, 0xC7, 0x31, 0xB1, 0x12, 0x10, 0x59, 0x27, 0x80, 0xEC, 0x5F },
            { 0x60, 0x51, 0x7F, 0xA9, 0x19, 0xB5, 0x4A, 0x0D, 0x2D, 0xE5, 0x7A, 0x9F, 0x93, 0xC9, 0x9C, 0xEF },
            { 0xA0, 0xE0, 0x3B, 0x4D, 0xAE, 0x2A, 0xF5, 0xB0, 0xC8, 0xEB, 0xBB, 0x3C, 0x83, 0x53, 0x99, 0x61 },
            { 0x17, 0x2B, 0x04, 0x7E, 0xBA, 0x77, 0xD6, 0x26, 0xE1, 0x69, 0x14, 0x63, 0x55, 0x21, 0x0C, 0x7D }

    };

    private byte[,] rcon = new byte[4, 10]
    {
        // Rcon Lookup Table
            { 0x01, 0x02, 0x04, 0x08, 0x10, 0x20, 0x40, 0x80, 0x1B, 0x36 },
            { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 },
            { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 },
            { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }
    };

    private int round_num;  //加密轮数
    private int key_len;    //字密钥长度

    private byte[,] state = new byte[4, 4];   //定义状态矩阵

    private byte[,] roundKey = new byte[4, 44];

    public static byte[] hexStringToByteArray(string hexString)
    {
        string[] hexStrings = hexString.Split(' ');
        byte[] byteArray = new byte[hexStrings.Length];

        for (int i = 0; i < hexStrings.Length; i++)
        {
            byteArray[i] = Convert.ToByte(hexStrings[i], 16);
        }
        return byteArray;
    }

    public static string byteArrayToHexString(byte[] byteArray)
    {
        return BitConverter.ToString(byteArray).Replace("-", " ");
    }

    private static void ConvertToState(byte[] input, byte[,] state)
    {
        // 将接收的明文转化为状态矩阵
        int index = 0;

        for (int col = 0; col < 4; col++)
        {
            for (int row = 0; row < 4; row++)
            {
                state[row, col] = input[index++];
            }
        }
    }

    private static byte[] ConvertToByteArray(byte[,] state)
    {
        // 将状态矩阵转换为字节数组形式的密文
        byte[] output = new byte[16];
        int index = 0;

        for (int col = 0; col < 4; col++)
        {
            for (int row = 0; row < 4; row++)
            {
                output[index++] = state[row, col];
            }
        }

        return output;
    }

    private static byte Multiply(byte a, byte b)
    {
        // 用于GF(2^8)运算
        byte result = 0;

        while (a != 0)
        {
            if ((a & 1) != 0)
            {
                result ^= b;
            }

            byte highBitSet = (byte)(b & 0x80);
            b <<= 1;

            if (highBitSet != 0)
            {
                b ^= 0x1B; // GF(2^8)的特殊多项式 x^8 + x^4 + x^3 + x + 1
            }

            a >>= 1;
        }

        return result;
    }


    private void SubBytes(byte[,] state)
    {
        // 实现字节替代操作
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                byte value = state[row, col];
                state[row, col] = sBox[value >> 4, value & 0x0F];
            }
        }
    }

    private void InvSubBytes(byte[,] state)
    {
        // 实现逆字节替代操作
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                byte value = state[row, col];
                state[row, col] = inv_sBox[value >> 4, value & 0x0F];
            }
        }
    }

    private void ShiftRows(byte[,] state)
    {
        // 实现行移位（ShiftRows）步骤
        byte temp;

        // 第二行循环左移1位
        temp = state[1, 0];
        state[1, 0] = state[1, 1];
        state[1, 1] = state[1, 2];
        state[1, 2] = state[1, 3];
        state[1, 3] = temp;

        // 第三行循环左移2位
        temp = state[2, 0];
        state[2, 0] = state[2, 2];
        state[2, 2] = temp;

        temp = state[2, 1];
        state[2, 1] = state[2, 3];
        state[2, 3] = temp;

        // 第四行循环左移3位
        temp = state[3, 3];
        state[3, 3] = state[3, 2];
        state[3, 2] = state[3, 1];
        state[3, 1] = state[3, 0];
        state[3, 0] = temp;
    }

    private void InvShiftRows(byte[,] state)
    {
        // 实现逆行移位操作
        byte temp;

        // 第二行循环右移一位
        temp = state[1, 3];
        state[1, 3] = state[1, 2];
        state[1, 2] = state[1, 1];
        state[1, 1] = state[1, 0];
        state[1, 0] = temp;

        // 第三行循环右移两位
        temp = state[2, 0];
        state[2, 0] = state[2, 2];
        state[2, 2] = temp;
        temp = state[2, 1];
        state[2, 1] = state[2, 3];
        state[2, 3] = temp;

        // 第四行循环右移三位
        temp = state[3, 0];
        state[3, 0] = state[3, 1];
        state[3, 1] = state[3, 2];
        state[3, 2] = state[3, 3];
        state[3, 3] = temp;
    }

    private void MixColumns(byte[,] state)
    {
        // 实现列混淆操作
        byte[] temp = new byte[4];

        for (int col = 0; col < 4; col++)
        {
            // 临时保存当前列的值
            for (int row = 0; row < 4; row++)
            {
                temp[row] = state[row, col];
            }

            // 列混淆操作
            state[0, col] = (byte)(Multiply(0x02, temp[0]) ^ Multiply(0x03, temp[1]) ^ Multiply(0x01, temp[2]) ^ Multiply(0x01, temp[3]));
            state[1, col] = (byte)(Multiply(0x01, temp[0]) ^ Multiply(0x02, temp[1]) ^ Multiply(0x03, temp[2]) ^ Multiply(0x01, temp[3]));
            state[2, col] = (byte)(Multiply(0x01, temp[0]) ^ Multiply(0x01, temp[1]) ^ Multiply(0x02, temp[2]) ^ Multiply(0x03, temp[3]));
            state[3, col] = (byte)(Multiply(0x03, temp[0]) ^ Multiply(0x01, temp[1]) ^ Multiply(0x01, temp[2]) ^ Multiply(0x02, temp[3]));
        }
    }

    private void InvMixColumns(byte[,] state)
    {
        // 实现逆列混淆操作
        byte[] temp = new byte[4];

        for (int col = 0; col < 4; col++)
        {
            // 临时保存当前列的值
            for (int row = 0; row < 4; row++)
            {
                temp[row] = state[row, col];
            }

            // 逆列混淆操作
            state[0, col] = (byte)(Multiply(0x0E, temp[0]) ^ Multiply(0x0B, temp[1]) ^ Multiply(0x0D, temp[2]) ^ Multiply(0x09, temp[3]));
            state[1, col] = (byte)(Multiply(0x09, temp[0]) ^ Multiply(0x0E, temp[1]) ^ Multiply(0x0B, temp[2]) ^ Multiply(0x0D, temp[3]));
            state[2, col] = (byte)(Multiply(0x0D, temp[0]) ^ Multiply(0x09, temp[1]) ^ Multiply(0x0E, temp[2]) ^ Multiply(0x0B, temp[3]));
            state[3, col] = (byte)(Multiply(0x0B, temp[0]) ^ Multiply(0x0D, temp[1]) ^ Multiply(0x09, temp[2]) ^ Multiply(0x0E, temp[3]));
        }
    }

    private void AddRoundKey(byte[,] state, byte[,] roundKey, int round)
    {
        // 实现轮密钥加（AddRoundKey）步骤
        for (int col = 0; col < 4; col++)
        {
            for (int row = 0; row < 4; row++)
            {
                state[row, col] ^= roundKey[row, round * 4 + col];
            }
        }
    }

    private void KeyExpansion(byte[] key, byte[,] roundKey, int mode)
    {
        if ( mode == 128 )
        {
            round_num = 10;
            key_len = 4;
        }
        else if ( mode == 192 )
        {
            round_num = 12;
            key_len = 6;
        }
        else if ( mode == 256 )
        {
            round_num = 14;
            key_len = 8;
        }

        // 实现密钥扩展（KeyExpansion）步骤
        byte[,] temp = new byte[4, 4];
        int nk = key_len; // 字密钥长度，对应AES-128
        int nb = 4; // 分组长度，对应AES-128
        int nr = round_num; // 轮数，对应AES-128

        // 复制初始密钥到 roundKey
        for (int i = 0; i < nk; i++)
        {
            roundKey[0, i] = key[i * nb];
            roundKey[1, i] = key[i * nb + 1];
            roundKey[2, i] = key[i * nb + 2];
            roundKey[3, i] = key[i * nb + 3];
        }

        // 生成其他轮的密钥
        for (int i = nk; i < nb * (nr + 1); i++)
        {
            for (int j = 0; j < 4; j++)
            {
                temp[j, 0] = roundKey[j, i - 1];
            }

            if (i % nk == 0)
            {
                // 执行密钥扩展核心操作

                // 字节循环左移
                byte tempByte = temp[0, 0];
                temp[0, 0] = temp[1, 0];
                temp[1, 0] = temp[2, 0];
                temp[2, 0] = temp[3, 0];
                temp[3, 0] = tempByte;

                // 字节代换
                temp[0, 0] = sBox[temp[0, 0] >> 4, temp[0, 0] & 0x0F];
                temp[1, 0] = sBox[temp[1, 0] >> 4, temp[1, 0] & 0x0F];
                temp[2, 0] = sBox[temp[2, 0] >> 4, temp[2, 0] & 0x0F];
                temp[3, 0] = sBox[temp[3, 0] >> 4, temp[3, 0] & 0x0F];

                // 轮常数异或
                temp[0, 0] ^= rcon[0, i / nk - 1];
            }

            // 计算当前轮的密钥
            for (int j = 0; j < 4; j++)
            {
                roundKey[j, i] = (byte)(roundKey[j, i - nk] ^ temp[j, 0]);
            }
        }
    }

    public string Encrypt(string plainText, string key, int mode)
    {
        // 实现主函数，包括密钥扩展、轮密钥加、字节代换、行移位、列混合等步骤
        // 返回加密后的密文

        if ( mode == 128 )
        {
            round_num = 10;
        }
        else if ( mode == 192 )
        {
            round_num = 12;
        }
        else if ( mode == 256 )
        {
            round_num = 14;
        }

        // 初始化状态矩阵state
        byte[,] state = new byte[4, 4];
        byte[,] roundKey = new byte[4, 4*(round_num + 1)];

        // 密钥扩展
        KeyExpansion(hexStringToByteArray(key), roundKey, mode);

        //将明文转化为状态矩阵
        ConvertToState(hexStringToByteArray(plainText), state);

        // 初始轮密钥加
        AddRoundKey(state, roundKey, 0);

        // 执行9轮的字节代换、行移位、列混合和轮密钥加
        for (int round = 1; round <= round_num - 1; round++)
        {
            SubBytes(state);
            ShiftRows(state);
            MixColumns(state);
            AddRoundKey(state, roundKey, round);
        }

        // 执行最后一轮的字节代换、行移位和轮密钥加
        SubBytes(state);
        ShiftRows(state);
        AddRoundKey(state, roundKey, round_num);

        // 将状态矩阵转换为密文
        string ciphertext = byteArrayToHexString(ConvertToByteArray(state));

        return ciphertext;
    }

    public string Decrypt(string ciphertext, string key, int mode)
    {
        if (mode == 128)
        {
            round_num = 10;
        }
        else if (mode == 192)
        {
            round_num = 12;
        }
        else if (mode == 256)
        {
            round_num = 14;
        }

        // 初始化状态矩阵state
        byte[,] state = new byte[4, 4];
        byte[,] roundKey = new byte[4, 4*(round_num + 1)];

        // 转换密钥为扩展密钥
        KeyExpansion(hexStringToByteArray(key), roundKey, mode);

        // 将密文转换为状态矩阵
        ConvertToState(hexStringToByteArray(ciphertext), state);

        // 逆初始轮密钥加
        AddRoundKey(state, roundKey, round_num);

        // 逆9轮加密
        for (int round = round_num - 1; round >= 1; round--)
        {
            InvShiftRows(state);
            InvSubBytes(state);
            AddRoundKey(state, roundKey, round);
            InvMixColumns(state);
        }

        // 逆最后一轮加密
        InvShiftRows(state);
        InvSubBytes(state);
        AddRoundKey(state, roundKey, 0);

        // 将解密后的明文转换为字节数组
        string plaintext = byteArrayToHexString(ConvertToByteArray(state));

        return plaintext;
    }

    public byte GetFirstByteofFirstSubByte(string plainText, string key, int mode, int encrypt_round)
    {
        if (mode == 128)
        {
            round_num = 10;
        }
        else if (mode == 192)
        {
            round_num = 12;
        }
        else if (mode == 256)
        {
            round_num = 14;
        }

        // 初始化状态矩阵state
        byte[,] state = new byte[4, 4];
        byte[,] roundKey = new byte[4, 4 * (round_num + 1)];

        // 密钥扩展
        KeyExpansion(hexStringToByteArray(key), roundKey, mode);

        //将明文转化为状态矩阵
        ConvertToState(hexStringToByteArray(plainText), state);

        // 初始轮密钥加
        AddRoundKey(state, roundKey, 0);

        // 执行 round 轮的字节代换、行移位、列混合和轮密钥加
        for (int r = 1; r <= encrypt_round; r++)
        {
            SubBytes(state);
            ShiftRows(state);
            MixColumns(state);
            AddRoundKey(state, roundKey, r);
        }

        // 获取第round次字节代换结果的第一个字节
        byte firstSubByte = state[0, 0];

        return firstSubByte;
    }

}

