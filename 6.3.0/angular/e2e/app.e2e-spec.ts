import { EventsAppTemplatePage } from './app.po';

describe('EventsApp App', function() {
  let page: EventsAppTemplatePage;

  beforeEach(() => {
    page = new EventsAppTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
