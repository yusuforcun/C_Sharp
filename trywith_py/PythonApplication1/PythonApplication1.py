# # from pytube import YouTube

# # yt = YouTube('https://www.youtube.com/watch?v=fwFX24MSBp4&list=RDfwFX24MSBp4&start_radio=1') #video link

# # # print(f"Video Baþlýðý: {yt.title}")
# # print(f"Video Sahibi: {yt.author}")
# # print(f"Thumbnail Resmi: {yt.thumbnail_url}")
# # print(f"Video Uzunluðu: {yt.length}")
# # print(f"Video Rating: {yt.rating}")
# # # print(f"Ýzlenme Sayýsý: {yt.views}")
# # print("*"*30)
# # # print(f"Video Açýklamasý: {yt.description}")
# # print("*"*30)


# -------------------------------------------

# from pytube import YouTube

# yt = YouTube('https://www.youtube.com/watch?v=qolmz4FlnZ0')

# for i in yt.streams:
#     print(i)

# -------------------------------------------

from pytube import YouTube

# Videoyu indirmek için YouTube URL'sini belirtin
video_url = "https://www.youtube.com/watch?v=MUrrbmycJw8"
def  download(video_url):
    # YouTube nesnesi oluþturun ve videoyu indirin
    yt = YouTube(video_url)
    # desired_resolution = '720p'  # Ýstenen çözünürlükü buraya girin
    # video = yt.streams.filter(res=desired_resolution).first()
    video = yt.streams.filter(progressive=True).order_by('resolution').desc().first()
    video.download()
    print("succes")

download(video_url)