﻿namespace Ray.BiliBiliTool.Agent.BiliBiliAgent.Dtos;

public class GetSpecialFollowingsRequest
{
    public GetSpecialFollowingsRequest(long userId)
    {
        Mid = userId;
    }

    public GetSpecialFollowingsRequest(long userId, long tagId)
    {
        Mid = userId;
        Tagid = tagId;
    }

    public long Mid { get; set; }

    /// <summary>
    /// TagId
    /// </summary>
    /// <sample>-10:特别关注</sample>
    public long Tagid { get; set; } = -10;

    public int Pn { get; set; } = 1;

    public int Ps { get; set; } = 20;

    public string Jsonp { get; set; } = "jsonp";

    //public string Callback { get; set; }
}
