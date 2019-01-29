// pages/plane/plane.js
var util=require('../../utils/util.js');
Page({

  /**
   * 页面的初始数据
   */
  data: {
    
    region: ['北京市', '北京市','全部'],
    regions: ['北京市', '北京市','全部'],



    date: '',
  },
  bindRegionChange: function (e) {
    this.setData({
      region: e.detail.value
    })
  },
  bindRegionChanges: function (e) {
    this.setData({
      regions: e.detail.value
    })
  },
  bindDateChange: function (e) {
    this.setData({
      date: e.detail.value
    })
  },
  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    var time = util.formatDate(new Date());
    this.setData({
      date:time,
    });

  },
  

  //明天
  Tomorrow:function(){
    var dd = this.data.date;
    var d=new Date(dd);
    d.setDate(d.getDate()+1);
    var year = d.getFullYear()
    var month = d.getMonth() + 1
    var day = d.getDate() 
    if(month<10){
      month='0'+month;
    }
    if(day<10){
      day='0'+day;
    }
    var de=year+'-'+month+'-'+day
    this.setData({
      date: de,
    });
  },
  //查询
  SelectPlane(){
    wx.navigateTo({
      url: '../planeorder/planeorder?region=' + this.data.region[1] + "&regions=" + this.data.regions[1]+"&date="+this.data.date,
    })
  }
})