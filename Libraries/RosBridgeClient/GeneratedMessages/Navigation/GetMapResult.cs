/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Navigation
{
public class GetMapResult : Message
{
[JsonIgnore]
public const string RosMessageName = "nav_msgs/GetMapResult";
public Navigation.OccupancyGrid map;
}
}
