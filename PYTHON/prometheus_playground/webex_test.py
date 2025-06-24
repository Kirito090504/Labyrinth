import time

from webexpythonsdk import WebexAPI

api = WebexAPI(
    access_token="OGM3NmY2ZjYtOTcxYS00ZjJmLWI5YzYtMzcwOTcxNmNkN2I5OTNlMGI0OGMtNzcx_P0A1_60c4241b-f916-4111-96c4-b4c6eecaa22e"
)

all_rooms = api.rooms.list()
# print(list(all_rooms))
rooms = ""
for room in all_rooms:
    print(f"{room.title} (owner: {api.people.get(room.creatorId).displayName})")
    rooms += f"{room.title} (owner: {api.people.get(room.creatorId).displayName})\n"
    # if "Test" in room.title:
    #     print(room.id)

sent_msg = api.messages.create(
    roomId="Y2lzY29zcGFyazovL3VybjpURUFNOnVzLXdlc3QtMl9yL1JPT00vYzcxYmRiYjAtNTg3ZS0xMWVmLTkzYWYtMGI0YTFiZjE2Nzlm",
    text=f"{rooms}\n\nThis message is from the Python API sent at {time.asctime()} and will be deleted after 10 seconds.",
)

time.sleep(10)

api.messages.delete(sent_msg.id)
