/*!
 * XMLファイルからメッセージを取得するクラス.
 * 
 * @file	XMLMessageRead.cs
 * @author	Lotos
 * @date	2015-11-01 14:19
 */

using UnityEngine;
using System.Collections;
using System.Xml;

public class XMLMessageRead : MonoBehaviour {

    /// <summary>
    /// メッセージを取得.
    /// </summary>
    /// <param name="tag">タグの指定.</param>
    /// <returns>メッセージを返す.</returns>
    public static string GetMessage(string tag) {
        TextAsset xmlTextAsset = Instantiate(Resources.Load("ソースのパス")) as TextAsset;
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(xmlTextAsset.text);
        XmlElement element = xmlDoc.DocumentElement;
        XmlNodeList node = element.GetElementsByTagName(tag);
        if (node.Count < 0) return null;
        return node.Item(0).InnerText;
    }
}
