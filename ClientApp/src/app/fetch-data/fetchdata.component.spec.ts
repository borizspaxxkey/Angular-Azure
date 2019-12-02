import { FetchDataComponent } from './fetch-data.component';
import { Http } from '@angular/http';
import { HttpClient } from '@angular/common/http';
import { TestBed, ComponentFixture } from '@angular/core/testing';

export class MockHttp {
  get(url: string) {
    return {
      subscribe: () => { }
    };
  }
}

let mockHttp: MockHttp;

//This lets me run Angular in a small isolated environment for fast unit tests.
let fixture: ComponentFixture<FetchDataComponent>;

describe('fetchdata', () => {

  beforeEach(() => {
    mockHttp = new MockHttp();
    spyOn(mockHttp, 'get').and.returnValue({ subscribe: () => { } });

    TestBed.configureTestingModule({
      declarations: [FetchDataComponent],
      providers: [
        { provide: HttpClient, useValue: mockHttp },
        { provide: 'BASE_URL', useValue: '' },
      ]
    });

    fixture = TestBed.createComponent(FetchDataComponent);
    fixture.detectChanges()
  });

  it('should call http.get', () => {
    expect(mockHttp.get).toHaveBeenCalled();
  })
})


//Tells us if a function gets called during a test
//spyOn()
//Karma is a Test Runner

//Jasmine is a Test Library
