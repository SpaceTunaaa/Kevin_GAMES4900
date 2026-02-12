extends Node

@export var receiver: Node

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	print("Hello Friend")
	receiver.OnCalled()
