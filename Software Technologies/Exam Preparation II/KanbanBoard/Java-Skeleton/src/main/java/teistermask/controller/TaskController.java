package teistermask.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import teistermask.bindingModel.TaskBindingModel;
import teistermask.entity.Task;
import teistermask.repository.TaskRepository;

import java.util.List;

@Controller
public class TaskController {
	private final TaskRepository taskRepository;

	@Autowired
	public TaskController(TaskRepository taskRepository) {
		this.taskRepository = taskRepository;
	}

	@GetMapping("/")
	public String index(Model model) {
		// TODO: Implement me...

		List<Task> openTasks = this.taskRepository.findAllByStatus("Open");
		List<Task> InProgressTasks = this.taskRepository.findAllByStatus("In Progress");
		List<Task> FinishedTasks = this.taskRepository.findAllByStatus("Finished");

		model.addAttribute("view", "task/index");
		model.addAttribute("openTasks", openTasks);
		model.addAttribute("inProgressTasks", InProgressTasks); //names come from index-view
		model.addAttribute("finishedTasks", FinishedTasks);		//if u mistake a letter it wont run !!

		return "base-layout";

	}

	@GetMapping("/create")
	public String create(Model model) {
		// TODO: Implement me...

		model.addAttribute("view", "task/create");
		return "base-layout";
	}

	@PostMapping("/create")
	public String createProcess(Model model, TaskBindingModel taskBindingModel) {
		// TODO: Implement me...

		Task task = new Task(
				taskBindingModel.getTitle(),
				taskBindingModel.getStatus()
		);

		this.taskRepository.saveAndFlush(task);

		return "redirect:/";

	}

	@GetMapping("/edit/{id}")
	public String edit(Model model, @PathVariable int id) {
		// TODO: Implement me...

		Task task = this.taskRepository.findOne(id);
		model.addAttribute("view", "task/edit");
		model.addAttribute("task", task);

		return "base-layout";

	}

	@PostMapping("/edit/{id}")
	public String editProcess(@PathVariable int id, TaskBindingModel taskBindingModel) {
		// TODO: Implement me...

		Task task = this.taskRepository.findOne(id);
		task.setTitle(taskBindingModel.getTitle());
		task.setStatus(taskBindingModel.getStatus());

		this.taskRepository.saveAndFlush(task);

		return "redirect:/";

	}
}
