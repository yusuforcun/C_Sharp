# # from pytube import YouTube

# # yt = YouTube('https://www.youtube.com/watch?v=fwFX24MSBp4&list=RDfwFX24MSBp4&start_radio=1') #video link

# # # print(f"Video Ba�l���: {yt.title}")
# # print(f"Video Sahibi: {yt.author}")
# # print(f"Thumbnail Resmi: {yt.thumbnail_url}")
# # print(f"Video Uzunlu�u: {yt.length}")
# # print(f"Video Rating: {yt.rating}")
# # # print(f"�zlenme Say�s�: {yt.views}")
# # print("*"*30)
# # # print(f"Video A��klamas�: {yt.description}")
# # print("*"*30)


# -------------------------------------------

# from pytube import YouTube

# yt = YouTube('https://www.youtube.com/watch?v=qolmz4FlnZ0')

# for i in yt.streams:
#     print(i)

# -------------------------------------------

from pytube import YouTube

# Videoyu indirmek i�in YouTube URL'sini belirtin
video_url = "https://www.youtube.com/watch?v=MUrrbmycJw8"
def  download(video_url):
    # YouTube nesnesi olu�turun ve videoyu indirin
    yt = YouTube(video_url)
    # desired_resolution = '720p'  # �stenen ��z�n�rl�k� buraya girin
    # video = yt.streams.filter(res=desired_resolution).first()
    video = yt.streams.filter(progressive=True).order_by('resolution').desc().first()
    video.download()
    print("succes")

download(video_url)