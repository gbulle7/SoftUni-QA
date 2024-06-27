const { test, expect } = require('@playwright/test');

// verify user can add task
test("User can add task", async({page})=>{
    //arange
    await page.goto('http://localhost:8080');

    //act
    await page.fill('#task-input', 'Test Task');
    await page.click('#add-task');

    //assert
    const taskText = await page.textContent('.task');
    expect(taskText).toContain('Test Task');
});

// verify user can delete task
test("User can delete task", async({page})=>{
    //arrange
    await page.goto('http://localhost:8080');
    await page.fill('#task-input', 'Test Task');
    await page.click('#add-task');

    //act
    await page.click('.task .delete-task');

    //assert
    const tasks = await page.$$eval('.task', tasks => tasks.map(task => task.textContent
    ));
    expect(tasks).not.toContain('Test Task');
});

// verify user can mark task as complete
test("User can mark task as complete", async({page})=>{
    //arrange
    await page.goto('http://localhost:8080');
    await page.fill('#task-input', 'Test Task');
    await page.click('#add-task');

    //act
    await page.click('.task .task-complete');

    //assert
    const completedTask = await page.$('.task.completed')
    expect(completedTask).not.toBeNull();
});

// verify user can filter tests
test("User can filter tests", async({page})=>{
    //arrange
    await page.goto('http://localhost:8080');
    await page.fill('#task-input', 'Test Task');
    await page.click('#add-task');
    await page.click('.task .task-complete');

    //act
    await page.selectOption('#filter', 'Completed');

    //assert
    const incompleteTask = await page.$('.task:not(.completed)');
    expect(incompleteTask).toBeNull();
});